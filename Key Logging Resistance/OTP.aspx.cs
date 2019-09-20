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

public partial class OTP : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["connection"]);
   
    string username;
   
    string msg;
   
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void Button2_Click(object sender, EventArgs e)
    {

      
        if (Session["otp"].ToString()==TextBox1.Text)
        {
            
            con.Open();
            SqlCommand cmd = new SqlCommand("update registrations set count="+0+",blocked='No' where username='"+Session["username"].ToString()+"'",con);
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("Edit.aspx");
        }
        else
        {
            Response.Write("<script LANGUAGE='JavaScript' >alert('Wrong OTP')</script>");
        }
             
            
        
    }

    
    

   
   
   
       
}
