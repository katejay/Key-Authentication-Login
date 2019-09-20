using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Facilities : System.Web.UI.Page
{
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
            
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["username"] = null;
        Session["accno"] = null;
        Response.Redirect("Default.aspx");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("Recharge.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
      Response.Redirect("Transfers.aspx");
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("MiniStatement.aspx");
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        Response.Redirect("Bills.aspx");
    }
}