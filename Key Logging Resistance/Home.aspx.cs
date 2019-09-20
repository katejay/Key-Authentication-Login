﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Home : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["connection"]);
    string username, accno;

    protected void Page_Load(object sender, EventArgs e)
    {
        username = Session["username"].ToString();
        Label1.Text = username;
       // accno = Session["accno"].ToString();
        if(Session["username"]==null)
        {
            Response.Redirect("Default.aspx");
        }
        else
        {
            Label1.Text = username;
            show_details();
        }
    }

    private void show_details()
    {
        con.Open();
        SqlDataAdapter da = new SqlDataAdapter("select * from registrations where username='"+username+"'", con);
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