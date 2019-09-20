<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OTP.aspx.cs" Inherits="OTP" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

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
           <h1><a href=" ">Key Logging for <span class="logo_colour">Banking</span></a></h1>
          <h2>Register. Click. Login.</h2>
        </div>
      </div>
      <div id="menubar">
        <ul id="menu">
          <!-- put class="selected" in the li tag for the selected page - to highlight which page you're on -->
          <li class="selected"><a href="Default.aspx">Home</a></li>
        </ul>
      </div>
    </div>
    <div id="site_content">
     <div class="sidebar">
         <asp:Button class="button" ID="Button1" runat="server" Text="Log Out" />
            
      <!--  insert your sidebar items here
        <h3>Latest News</h3>
        <h4>New Website Launched</h4>
        <h5>August 1st, 2013</h5>
        <p>2013 sees the redesign of our website. Take a look around and let us know what you think.<br /><a href="#">Read more</a></p>
        <p></p>
        <h4>New Website Launched</h4>
        <h5>August 1st, 2013</h5>
        <p>2013 sees the redesign of our website. Take a look around and let us know what you think.<br /><a href="#">Read more</a></p>
        <h3>Useful Links</h3>
        <ul>
          <li><a href="#">link 1</a></li>
          <li><a href="#">link 2</a></li>
          <li><a href="#">link 3</a></li>
          <li><a href="#">link 4</a></li>
        </ul>
        <h3>Search</h3>
        <form method="post" action="#" id="search_form">
          <p>
            <input class="search" type="text" name="search_field" value="Enter keywords....." />
            <input name="search" type="image" style="border: 0; margin: 0 0 -9px 5px;" src="style/search.png" alt="Search" title="Search" />
          </p>
        </form> -->
      </div>
      <div id="content">
        <!-- insert the page content here -->
        <h1>Welcome 
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label> to Credit Card Fraud 
            Detection</h1>
          <h1>Your account is blocked.(You attemp the three time wrong login attempt.)<br />
              So for unblocked your account we send a otp on register mobile number.<br />
              Enter The Otp:
          </h1>
          <center>
              <asp:Panel ID="Panel1" runat="server" Height="200px" Width="400px">
              <p>Verify OTP:<asp:Label ID="Label2" runat="server" Text=""></asp:Label>
                  <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                  </p>
                  <asp:TextBox ID="TextBox1" CssClass="textarea" runat="server" 
                      TextMode="Password"></asp:TextBox><br /><br />
                  <asp:Button ID="Button2" CssClass="button" runat="server" Text="Verify" 
                      onclick="Button2_Click" />
              </asp:Panel>
       
          </center>
        </div>
    </div>
    <div id="footer">
        Copyright © BHARTI VIDYAPEETH STUDENTS@2016. All Rights Reserved. 
  </div>
    </form>
</body>
</html>
