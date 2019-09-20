using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

public partial class Edit : System.Web.UI.Page
{

    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["connection"]);
    string username;
    string name;
    protected void Page_Load(object sender, EventArgs e)
    {
        username = (string)Session["username"];
        name = (string)Session["name"];
        Label1.Text = name;
        if (!IsPostBack)
        {
           
            show_data();
        }
    }

    private void show_data()
    {
        con.Open();
        SqlDataAdapter ad = new SqlDataAdapter("Select * from registrations where username='" + username + "'", con);
        DataSet s = new DataSet();
        ad.Fill(s);
        if (s.Tables[0].Rows.Count > 0)
        {
            TextBox1.Text = s.Tables[0].Rows[0]["username"].ToString();
            TextBox2.Text = s.Tables[0].Rows[0]["password"].ToString();
            
        }
        con.Close();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("update registrations set username = '" + TextBox1.Text + "', password = '" + TextBox2.Text + "' where username='"+TextBox1.Text+"'", con);
        cmd.ExecuteNonQuery();
        Response.Write("<script LANGUAGE='JavaScript' >alert('Successfully Updated!')</script>");
        con.Close();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
       
        Session["name"] = null;
        Session["username"] = null;
        Response.Redirect("Default.aspx");
    }

   
}
