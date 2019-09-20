<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Edit.aspx.cs" Inherits="Edit" %>

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
          <h2>&nbsp;</h2>
        </div>
      </div>
      <div id="menubar">
        <ul id="menu">
          <!-- put class="selected" in the li tag for the selected page - to highlight which page you're on -->
           <li ><a href="Home.aspx">Home</a></li>
     
         <li><a href="Facilities.aspx">Facilities</a></li>
             <li><a href="Deposit.aspx">Deposit</a></li>
          
              <li ><a href="Update.aspx">UpdateDetail</a></li>
             <li class="selected"><a href="Edit.aspx">Edit</a></li>
          
          
        </ul>
      </div>
    </div>
    <div id="site_content">
     <div class="sidebar">
         <asp:Button class="button" ID="Button1" runat="server" Text="Log Out" 
             onclick="Button1_Click" />
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
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label> to InternetBanking</h1>
            <p>Name:</p>
          <asp:TextBox CssClass="textarea" ID="TextBox1" runat="server"></asp:TextBox>
             <p>Password:</p>
          <asp:TextBox CssClass="textarea" ID="TextBox2" runat="server"></asp:TextBox>
          <br /><br /><br /><asp:Button CssClass="button" ID="Button2" runat="server" 
              Text="Update" onclick="Button2_Click" />
        </div>
    </div>
    <div id="footer">
      Copyright &copy;&nbsp; BHARTI VIDYAPEETH STUDENT@2016 | All Rights Reserved.
    </div>
  </div>
    </form>
</body>
</html>
