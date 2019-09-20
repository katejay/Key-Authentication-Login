using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
public partial class Update : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["connection"]);
    string username, accno;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"] != null)
        {
            username = Session["username"].ToString();
            if (!IsPostBack)
            {
                Label1.Text = Session["username"].ToString();
                //get record of user

                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from registrations where username='"+username+"'", con);
                DataSet ds = new DataSet();
                da.Fill(ds);

                con.Close();

                if (ds.Tables[0].Rows.Count > 0)
                {
                    TextBox1.Text = ds.Tables[0].Rows[0]["username"].ToString();
                    TextBox2.Text = ds.Tables[0].Rows[0]["email"].ToString();
                    TextBox3.Text = ds.Tables[0].Rows[0]["mobile"].ToString();
                    TextBox4.Text = ds.Tables[0].Rows[0]["city"].ToString();

                }
            }
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text != "" && TextBox2.Text != "" && TextBox3.Text != "" && TextBox4.Text != "" && TextBox5.Text != "" && TextBox6.Text != "")
        {
            con.Open();
            //get prev password 
            SqlDataAdapter da = new SqlDataAdapter("select * from registrations where username='" + username + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (TextBox5.Text == ds.Tables[0].Rows[0]["password"].ToString())
                {
                    //correct prevpassword update information
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update registrations set username='" + TextBox1.Text + "',password='" + TextBox6.Text + "',email='" + TextBox2.Text + "',mobile='" + TextBox3.Text + "',city='" + TextBox4.Text + "' where username='" + username + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Response.Write("<script language=javascript>alert('Updated');</script>");
                    clearall();
                }
                else
                {//wrong password
                    Response.Write("<script language=javascript>alert('Wrong Prev. Password');</script>");
                }
            }
        }
        else
        {
            Response.Write("<script language=javascript>alert('Fill All Details First..');</script>");

        }
    }
    private void clearall()
    {
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
        TextBox6.Text = "";
        

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["username"] = null;
        Session["accno"] = null;
        Response.Redirect("Default.aspx");
    }
}