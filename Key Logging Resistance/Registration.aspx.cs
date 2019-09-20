using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Registration : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["connection"]);

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        
           con.Open();
           SqlCommand cmd = new SqlCommand("insert into registrations values('" + TextBox1.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','0','No')", con);
           cmd.ExecuteNonQuery();
           con.Close();
           Response.Write("<script LANGUAGE='JavaScript' >alert('Registration Successful!')</script>");
           TextBox1.Text = "";
           TextBox2.Text = "";
           TextBox3.Text = "";
           TextBox4.Text = "";
           TextBox5.Text = "";
           TextBox6.Text = "";
           TextBox7.Text = "";
           TextBox8.Text = "";
       
    }
    protected void TextBox5_TextChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox5_Unload(object sender, EventArgs e)
    {

    }
    protected void TextBox5_Disposed(object sender, EventArgs e)
    {

    }
    protected void TextBox5_Load(object sender, EventArgs e)
    {

    }
    protected void TextBox5_TextChanged1(object sender, EventArgs e)
    {
        con.Open();
        SqlDataAdapter da1 = new SqlDataAdapter("select * from registrations where accountno='" + TextBox5.Text + "'", con);
        DataSet ds1 = new DataSet();
        da1.Fill(ds1);
        con.Close();
        if (ds1.Tables[0].Rows.Count>0)
        {
            Response.Write("<script LANGUAGE='JavaScript' >alert('Please Enter Your Account Number!')</script>");
        }
        else
        {
                
        
        con.Open();
        SqlDataAdapter da = new SqlDataAdapter("select * from accounts where accountno='" + TextBox5.Text + "'", con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        con.Close();
        if (ds.Tables[0].Rows.Count > 0)
        {
            string bal = ds.Tables[0].Rows[0]["balance"].ToString();

            TextBox6.Text = bal;
        }
        }
    }
}