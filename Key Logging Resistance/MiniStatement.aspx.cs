using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class MiniStatement : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["connection"]);
    string username, accno;

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
            mini_statement();

        }
    }

    private void mini_statement()
    {
        con.Open();
        SqlDataAdapter da = new SqlDataAdapter("select top 5 * from statement where fromuser='"+username+"' order by date", con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        con.Close();
        if(ds.Tables[0].Rows.Count > 0)
        {
            GridView1.Visible = true;
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["username"] = null;
        Session["accno"] = null;
        Response.Redirect("Default.aspx");
    }
}