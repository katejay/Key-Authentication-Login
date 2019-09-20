<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

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
          <li class="selected"><a href="Home.aspx">Home</a></li>
     
         <li><a href="Facilities.aspx">Facilities</a></li>
             <li><a href="Deposit.aspx">Deposit</a></li>
          
              <li ><a href="Update.aspx">UpdateDetail</a></li>
             <li class="selected"><a href="Edit.aspx">Edit</a></li>
          
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
          <asp:GridView ID="GridView1" runat="server" CssClass="input" AutoGenerateColumns="False" CellPadding="5" CellSpacing="4">
              <Columns>
                  <asp:BoundField DataField="accountno" HeaderText="accountno" />
                  <asp:BoundField DataField="fullname" HeaderText="Name" />
                  <asp:BoundField DataField="bal" HeaderText="Balance" />
              </Columns>
          </asp:GridView>
          <div style="height:400px"></div>
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
