using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using QRCoder;
using System.IO;
using System.Drawing;
using System.Data.SqlClient;
using System.Net;



public partial class Registration : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["connection"]);
    int counts;
    int x = 6;
    int y = 6;
    string[,] data = new string[6, 6];
    static char[] r = new char[36];
    Random random = new Random();
    static string rchar;
    string v1, v2, v3, v4, v5, v6, vl1, vl2, vl3, vl4, vl5, vl6, vq1, vq2, vq3, vq4, vq5, vq6, vw1, vw2, vw3, vw4, vw5, vw6, vr1, vr2, vr3, vr4, vr5, vr6, vt1, vt2, vt3, vt4, vt5, vt6;

    DataTable dt = new DataTable();
    string schar = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();
        SqlDataAdapter da1 = new SqlDataAdapter("select * from registrations where username='" + TextBox1.Text + "'", con);
        DataSet ds1 = new DataSet();
        da1.Fill(ds1);
        con.Close();
        if (ds1.Tables[0].Rows.Count>0)
        {
             counts=Convert.ToInt32(ds1.Tables[0].Rows[0]["count"]);
                string mobile = ds1.Tables[0].Rows[0]["mobile"].ToString();
               
            if (counts >= 3)
            {
                Response.Write("<script LANGUAGE=javascript>alert('You r Blocked')</script>");
                #region sms
                Random r = new Random();
                int otp = r.Next(1111,9999);
                Session["username"] = TextBox1.Text;
                string msg="Your are blocked pleease put your otp to unblocked";
                
                Session["otp"] = otp;
                string strUrl = "http://api.mVaayoo.com/mvaayooapi/MessageCompose?user=emailid:password&senderID=TEST SMS&receipientno=" + mobile + "&msgtxt=" + otp + "&state=4";
                WebRequest request = HttpWebRequest.Create(strUrl);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream s = (Stream)response.GetResponseStream();
                StreamReader readStream = new StreamReader(s);
                string dataString = readStream.ReadToEnd();
                response.Close();
                s.Close();
                readStream.Close();

                #endregion
                Response.Write("<script LANGUAGE='JavaScript' >alert('You r Blocked!')</script>");
                Response.Redirect("OTP.aspx");

            }
            else
            {

                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from registrations where username='" + TextBox1.Text + "'", con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                con.Close();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    string pass = ds.Tables[0].Rows[0]["password"].ToString();
                    int count = 36 - pass.Length;
                    string output = "";
                    for (int i = 0; i < count; i++)
                    {
                        output = output + "-";
                    }
                    string pswd = pass + output;


                    //--------Random Non-Repeating Arrays--------//
                    r = pswd.OrderBy(z => random.Next()).Take(36).ToArray();
                    rchar = new string(r);

                    // var random = new Random();
                    //data = new string[x, y];

                    dt = null;
                    dt = new DataTable();
                    int k = 0;
                    for (int i = 0; i < x; i++)
                    {
                        dt.Columns.Add(i.ToString());
                    }
                    for (int i = 0; i < x; i++)
                    {

                        for (int j = 0; j < y; j++)
                        {

                            data[i, j] = rchar[k].ToString();

                            k++;
                        }



                        dt.Rows.Add(data[i, 0], data[i, 1], data[i, 2], data[i, 3], data[i, 4], data[i, 5]);













                    }
                    Session["data"] = data;
                    //GridView1.DataSource = dt;
                    //GridView1.DataBind();

                    //for (int l = 0; l < 6; l++)
                    //{
                    //    for (int z = 0; z < 6; z++)
                    //    {
                    //        var test = GridView1.Rows[l].Cells[z].Text = string.Empty;
                    //    }
                    //}
                    //--------Random Non-Repeating Arrays--------//
                    //--------Table--------//
                    for (int i = 0; i < x; i++)
                    {
                        var newRow = new TableRow();
                        for (int j = 0; j < y; j++)
                        {
                            var newCell = new TableCell();
                            newCell.Text = data[i, j];
                            newRow.Cells.Add(newCell);

                            if (i == 0)
                            {
                                if (j == 0)
                                {
                                    vl1 = data[i, j].ToString();
                                }
                                if (j == 1)
                                {
                                    vl2 = vl1 + " " + "\t" + data[i, j].ToString();
                                }
                                if (j == 2)
                                {
                                    vl3 = vl2 + " " + "\t" + data[i, j].ToString();
                                }
                                if (j == 3)
                                {
                                    vl4 = vl3 + " " + "\t" + data[i, j].ToString();
                                }
                                if (j == 4)
                                {
                                    vl5 = vl4 + " " + "\t" + data[i, j].ToString();
                                }
                                if (j == 5)
                                {
                                    vl6 = vl5 + " " + "\t" + data[i, j].ToString();
                                }

                            }
                            if (i == 1)
                            {
                                if (j == 0)
                                {
                                    v1 = vl6 + System.Environment.NewLine + System.Environment.NewLine + data[i, j].ToString();
                                }
                                if (j == 1)
                                {
                                    v2 = v1 + " " + "\t" + data[i, j].ToString();
                                }
                                if (j == 2)
                                {
                                    v3 = v2 + " " + "\t" + data[i, j].ToString();
                                }
                                if (j == 3)
                                {
                                    v4 = v3 + " " + "\t" + data[i, j].ToString();
                                }
                                if (j == 4)
                                {
                                    v5 = v4 + " " + "\t" + data[i, j].ToString();
                                }
                                if (j == 5)
                                {
                                    v6 = v5 + " " + "\t" + data[i, j].ToString();
                                }

                            }
                            if (i == 2)
                            {
                                if (j == 0)
                                {
                                    vq1 = v6 + System.Environment.NewLine + System.Environment.NewLine + data[i, j].ToString();
                                }
                                if (j == 1)
                                {
                                    vq2 = vq1 + " " + "\t" + data[i, j].ToString();
                                }
                                if (j == 2)
                                {
                                    vq3 = vq2 + " " + "\t" + data[i, j].ToString();
                                }
                                if (j == 3)
                                {
                                    vq4 = vq3 + " " + "\t" + data[i, j].ToString();
                                }
                                if (j == 4)
                                {
                                    vq5 = vq4 + " " + "\t" + data[i, j].ToString();
                                }
                                if (j == 5)
                                {
                                    vq6 = vq5 + " " + "\t" + data[i, j].ToString();
                                }

                            }
                            if (i == 3)
                            {
                                if (j == 0)
                                {
                                    vt1 = vq6 + System.Environment.NewLine + System.Environment.NewLine + data[i, j].ToString();
                                }
                                if (j == 1)
                                {
                                    vt2 = vt1 + " " + "\t" + data[i, j].ToString();
                                }
                                if (j == 2)
                                {
                                    vt3 = vt2 + " " + "\t" + data[i, j].ToString();
                                }
                                if (j == 3)
                                {
                                    vt4 = vt3 + " " + "\t" + data[i, j].ToString();
                                }
                                if (j == 4)
                                {
                                    vt5 = vt4 + " " + "\t" + data[i, j].ToString();
                                }
                                if (j == 5)
                                {
                                    vt6 = vt5 + " " + "\t" + data[i, j].ToString();
                                }

                            }
                            if (i == 4)
                            {
                                if (j == 0)
                                {
                                    vr1 = vt6 + System.Environment.NewLine + System.Environment.NewLine + data[i, j].ToString();
                                }
                                if (j == 1)
                                {
                                    vr2 = vr1 + " " + "\t" + data[i, j].ToString();
                                }
                                if (j == 2)
                                {
                                    vr3 = vr2 + " " + "\t" + data[i, j].ToString();
                                }
                                if (j == 3)
                                {
                                    vr4 = vr3 + " " + "\t" + data[i, j].ToString();
                                }
                                if (j == 4)
                                {
                                    vr5 = vr4 + " " + "\t" + data[i, j].ToString();
                                }
                                if (j == 5)
                                {
                                    vr6 = vr5 + " " + "\t" + data[i, j].ToString();
                                }

                            }
                            if (i == 5)
                            {
                                if (j == 0)
                                {
                                    vw1 = vr6 + System.Environment.NewLine + System.Environment.NewLine + data[i, j].ToString();
                                }
                                if (j == 1)
                                {
                                    vw2 = vw1 + " " + "\t" + data[i, j].ToString();
                                }
                                if (j == 2)
                                {
                                    vw3 = vw2 + " " + "\t" + data[i, j].ToString();
                                }
                                if (j == 3)
                                {
                                    vw4 = vw3 + " " + "\t" + data[i, j].ToString();
                                }
                                if (j == 4)
                                {
                                    vw5 = vw4 + " " + "\t" + data[i, j].ToString();
                                }
                                if (j == 5)
                                {
                                    vw6 = vw5 + " " + "\t" + data[i, j].ToString();
                                }

                            }
                        }
                        Table1.Rows.Add(newRow);

                      


                    }
                    string p =String.Concat( r);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into tpass values('" + p + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();


                    //--------Table--------//
                    //r = schar.OrderBy(z => random.Next()).Take(36).ToArray();

                    // string code = txtCode.Text;


                    QRCodeGenerator qrGenerator = new QRCodeGenerator();
                    QRCodeGenerator.QRCode qrCode = qrGenerator.CreateQrCode(vw6, QRCodeGenerator.ECCLevel.Q);
                    System.Web.UI.WebControls.Image imgBarCode = new System.Web.UI.WebControls.Image();
                    imgBarCode.Height = 150;
                    imgBarCode.Width = 150;
                    using (Bitmap bitMap = qrCode.GetGraphic(20))
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            bitMap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                            byte[] byteImage = ms.ToArray();
                            imgBarCode.ImageUrl = "data:image/png;base64," + Convert.ToBase64String(byteImage);
                        }
                        PlaceHolder1.Controls.Add(imgBarCode);

                    }

                    


                }


                else
                {
                    Response.Write("<script LANGUAGE='JavaScript' >alert('Invalid Username')</script>");
                }
            }
        }
    }



    protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
    {
        //  string CellText = this.GridView1.SelectedRow.Cells[cellindex].Text;
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        string final = "";
        string str = Request.Form["result1"];

        string[,] newarr = (string[,])(Session["data"]);
        string[] arr1 = str.Split('_');
        for (int i = 0; i < arr1.Length - 1; i++)
        {
            string[] temp = arr1[i].Split(',');
            int row = Convert.ToInt32(temp[0]);
            int col = Convert.ToInt32(temp[1]);
            final = final + newarr[row, col];
        }
        con.Open();
        SqlDataAdapter da = new SqlDataAdapter("select * from registrations where username='" + TextBox1.Text + "' and password='" + final + "'", con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        con.Close();
        if (ds.Tables[0].Rows.Count > 0)
        {
           
            Session["username"] = TextBox1.Text;
            Session["accno"]=ds.Tables[0].Rows[0]["accountno"].ToString();
            con.Open();
            SqlCommand cmd = new SqlCommand("update registrations set count=0 where username='"+TextBox1.Text+"'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("Home.aspx");
        }
        else
        {
            con.Open();
            SqlDataAdapter da1 = new SqlDataAdapter("select * from registrations where username='"+TextBox1.Text+"'", con);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            con.Close();
            if (ds1.Tables[0].Rows.Count > 0)
            {
               int count = Convert.ToInt32(ds1.Tables[0].Rows[0]["count"]);
                if (count>=3)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update registrations set blocked='yes' where username='"+TextBox1.Text+"'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Response.Write("<script LANGUAGE='JavaScript' >alert('You r Blocked!')</script>");
                    

                }
                else
                {
                    int result = count + 1;
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update registrations set count="+result+" where username='" + TextBox1.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                   
                    Response.Write("<script language=javascript>alert('Wrong username or password!')</script>");
                    
                    UpdatePanel1.Update();
                }
            }
           
          
           
           
        }
    }
    protected void btnGetTime_Click(object sender, EventArgs e)
    {
       
    }
}