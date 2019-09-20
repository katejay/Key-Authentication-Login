<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Update.aspx.cs" Inherits="Update" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta name="description" content="website description" />
  <meta name="keywords" content="website keywords, website keywords" />
  <meta http-equiv="content-type" content="text/html; charset=windows-1252" />
  <link rel="stylesheet" type="text/css" href="style/style.css" title="style" />
  
   
</head>
<body>
    <form id="form1" runat="server">
       
    <div id="main">
    <div id="header">
      <div id="logo">
        <div id="logo_text">
          <!-- class="logo_colour", allows you to change the colour of the text -->
          <h1><a href="Home.aspx">Internet<span class="logo_colour">Banking</span></a></h1>
          <h2>Login. View. Transfer.</h2>
        </div>
      </div>
      <div id="menubar">
        <ul id="menu">
          <!-- put class="selected" in the li tag for the selected page - to highlight which page you're on -->
          <li ><a href="Home.aspx">Home</a></li>
         <li><a href="Facilities.aspx">Facilities</a></li>
             <li><a href="Deposit.aspx">Deposit</a></li>
            
              <li class="selected"><a href="Update.aspx">UpdateDetail</a></li>
          
        </ul>
      </div>
    </div>
    <div id="site_content">
      <div class="sidebar">
        <!-- insert your sidebar items here -->
        <h4>Welcome: <asp:Label ID="Label1" runat="server" Text="" ForeColor="Red"></asp:Label></h4><br /><br />
          <asp:Button ID="Button1" CssClass="submit" runat="server" Text="Log Out" OnClick="Button1_Click" />
      </div>
      <div id="content">
        <!-- insert the page content here -->
        <h1>Welcome to Internet Banking</h1>
          <p>USername</p>
          <asp:TextBox ID="TextBox1" CssClass="input" runat="server"></asp:TextBox>
          <p>Previous Password</p>
          <asp:TextBox ID="TextBox5" TextMode="Password" CssClass="input" runat="server"></asp:TextBox>
          <p>New Password</p>
          <asp:TextBox ID="TextBox6" TextMode="Password" CssClass="input" runat="server"></asp:TextBox>

          <p>Email</p>
          <asp:TextBox ID="TextBox2" CssClass="input" runat="server"></asp:TextBox>
          <p>Mobile</p>
          <asp:TextBox ID="TextBox3" CssClass="input" runat="server"></asp:TextBox>
          <p>City</p>
          <asp:TextBox ID="TextBox4" CssClass="input" runat="server"></asp:TextBox>

         <br />
          <br />
          <asp:Button ID="Button2" runat="server" CssClass="submit" Text="Update" OnClick="Button2_Click" />
      </div>
    </div>
    <div id="content_footer"></div>
    <div id="footer">
      Copyright &copy; BHARTI VIDYAPEETH STUDENT@2016 | <a href="#">Designed By TYCM Group</a>
    </div>
  </div>
  
    </form>
</body>
</html>