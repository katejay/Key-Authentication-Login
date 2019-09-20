using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Net;

public partial class Transfers : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["connection"]);
    string username, accno, toaccno, date, time, otp;
    int bal, amount, finalbal;
    Random r = new Random();

    protected void Page_Load(object sender, EventArgs e)
    {
        username = Session["username"].ToString();
        accno = Session["accno"].ToString();
        if (Session["username"] == null)
        {
            Response.Redirect("Default.aspx");
        }
        else
        {
            Label1.Text = username;
            if (!IsPostBack)
            {
                Panel1.Visible = true;
                Panel2.Visible = false;
                Panel3.Visible = false;
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["username"] = null;
        Response.Redirect("Default.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        con.Open();
        SqlDataAdapter da = new SqlDataAdapter("select * from registrations where accountno='"+TextBox1.Text+"'", con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        con.Close();
        if (ds.Tables[0].Rows.Count > 0)
        {
            con.Open();
            SqlDataAdapter da1 = new SqlDataAdapter("select * from registrations where accountno='"+TextBox1.Text+"'", con);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            con.Close();
            if (ds1.Tables[0].Rows.Count > 0)
            {
                if(accno==TextBox1.Text)
                {
                    Response.Write("<script LANGUAGE='JavaScript' >alert('You have entered your own Account Number!')</script>");
                }
                else
                {
                    con.Open();
                    SqlDataAdapter da2 = new SqlDataAdapter("select * from registrations where username='" + username + "'", con);
                    DataSet ds2 = new DataSet();
                    da2.Fill(ds2);
                    con.Close();
                    if (ds2.Tables[0].Rows.Count > 0)
                    {
                        bal = Convert.ToInt32(ds2.Tables[0].Rows[0]["bal"]);
                        Label3.Text = bal.ToString();
                        string mobile = ds2.Tables[0].Rows[0]["mobile"].ToString();
                        amount = Convert.ToInt32(TextBox2.Text);
                        if(bal >= amount)
                        {
                            otp = r.Next(12345, 54321).ToString();
                            Label2.Text = otp;
                            string msg = "Your verification code is: " + otp;
                     
                            Response.Write("<script LANGUAGE='JavaScript' >alert('"+otp+"')</script>");
                            #region sms


                            string strUrl = "http://api.mVaayoo.com/mvaayooapi/MessageCompose?user=emailid:password&senderID=TEST SMS&receipientno=" + mobile + "&msgtxt=" + msg + "&state=4";
                            WebRequest request = HttpWebRequest.Create(strUrl);
                            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                            Stream s = (Stream)response.GetResponseStream();
                            StreamReader readStream = new StreamReader(s);
                            string dataString = readStream.ReadToEnd();
                            response.Close();
                            s.Close();
                            readStream.Close();

                            #endregion

                            Panel1.Visible = false;
                            Panel2.Visible = true;
                            Panel3.Visible = false;

                        }
                        else
                        {
                            Response.Write("<script LANGUAGE='JavaScript' >alert('Insufficient Balance!')</script>");
                        }
                    }
                }
            }
        }
        else
        {
            Response.Write("<script LANGUAGE='JavaScript' >alert('Account Number does not exist!')</script>");
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        if(Label2.Text==TextBox3.Text)
        {
            toaccno = TextBox1.Text;
            int fromfinalbal = Convert.ToInt32(Label3.Text) - Convert.ToInt32(TextBox2.Text);
            date = DateTime.Now.ToShortDateString();
            time = DateTime.Now.ToShortTimeString();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from registrations where accountno='"+toaccno+"'", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            if (ds.Tables[0].Rows.Count > 0)
            {
                int tobal = Convert.ToInt32(ds.Tables[0].Rows[0]["bal"]);
                int tofinalbal = tobal + Convert.ToInt32(TextBox2.Text);
                string user = ds.Tables[0].Rows[0]["username"].ToString();
                con.Open();
                SqlCommand cmd1 = new SqlCommand("update registrations set bal='" + fromfinalbal.ToString() + "' where username='" + username + "'", con);
                cmd1.ExecuteNonQuery();
                con.Close();

                con.Open();
                SqlCommand cmd2 = new SqlCommand("update registrations set bal='" + tofinalbal.ToString() + "' where username='" + user + "'", con);
                cmd2.ExecuteNonQuery();
                con.Close();

                con.Open();
                SqlCommand cmd3 = new SqlCommand("insert into statement values('" + username + "','" + user + "','" + TextBox2.Text + "','Online Transfer','" + date + "','" + time + "','Debit')", con);
                cmd3.ExecuteNonQuery();
                con.Close();

                con.Open();
                SqlCommand cmd4 = new SqlCommand("insert into statement values('" + user + "','" + username + "','" + TextBox2.Text + "','Online Transfer','" + date + "','" + time + "','Credit')", con);
                cmd4.ExecuteNonQuery();
                con.Close();

                Response.Write("<script LANGUAGE='JavaScript' >alert('Transfer Successful!')</script>");

                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";

                Panel3.Visible = true;
                Panel1.Visible = false;
                Panel2.Visible = false;
            }
        }
        else
        {
            Response.Write("<script LANGUAGE='JavaScript' >alert('Invalid Code!')</script>");
        }
    }
}