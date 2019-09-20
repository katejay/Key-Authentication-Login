<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MiniStatement.aspx.cs" Inherits="MiniStatement" %>

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
         <h2>Mini Statement</h2>
          <asp:GridView ID="GridView1" runat="server" CellPadding="5" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" CellSpacing="4">
              <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
              <Columns>
                  <asp:BoundField DataField="touser" HeaderText="Account #" />
                  <asp:BoundField DataField="amount" HeaderText="Amount" />
                  <asp:BoundField DataField="description" HeaderText="Description" />
                  <asp:BoundField DataField="type" HeaderText="Type" />
              </Columns>
              <EditRowStyle BackColor="#999999" />
              <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
              <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
              <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
              <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
              <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
              <SortedAscendingCellStyle BackColor="#E9E7E2" />
              <SortedAscendingHeaderStyle BackColor="#506C8C" />
              <SortedDescendingCellStyle BackColor="#FFFDF8" />
              <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
          </asp:GridView>
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
