using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Deposit : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["connection"]);
    string username, accno;
    int bal;

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
            show_bal();
        }
    }

    private void show_bal()
    {
        con.Open();
        SqlDataAdapter da = new SqlDataAdapter("select * from registrations where username='"+username+"'", con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        con.Close();
        if (ds.Tables[0].Rows.Count > 0)
        {
            bal = Convert.ToInt32(ds.Tables[0].Rows[0]["bal"]);
            Label2.Text = bal.ToString();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["username"] = null;
        Session["accno"] = null;
        Response.Redirect("Default.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        int deposit = Convert.ToInt32(TextBox1.Text);
        int finalbal = bal + deposit;
        
        con.Open();
        SqlCommand cmd = new SqlCommand("update accounts set balance='"+finalbal.ToString()+"' where accountno='"+Session["accno"].ToString()+"'",con);
        cmd.ExecuteNonQuery();
        con.Close();

        con.Open();
         cmd = new SqlCommand("update registrations set bal='" + finalbal.ToString() + "' where username='" + username + "'", con);
        cmd.ExecuteNonQuery();
        con.Close();

        con.Open();
        SqlCommand mycmd = new SqlCommand("insert into statement values('" + username + "','" + username + "','" + deposit.ToString() + "','SELF DEPOSIT','" + DateTime.Now.ToShortDateString() + "','" + DateTime.Now.ToShortTimeString() + "','Credit')", con);
        mycmd.ExecuteNonQuery();
        con.Close();

        Response.Write("<script LANGUAGE='JavaScript' >alert('Deposit Successful!')</script>");

        show_bal();
    }
}