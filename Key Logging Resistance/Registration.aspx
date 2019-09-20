<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <meta name="description" content="website description" />
  <meta name="keywords" content="website keywords, website keywords" />
  <meta http-equiv="content-type" content="text/html; charset=windows-1252" />
  <link rel="stylesheet" type="text/css" href="style/style.css" title="style" />
    <style type="text/css">
        .submit {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
     <div id="main">
    <div id="header">
      <div id="logo">
        <div id="logo_text">
          <!-- class="logo_colour", allows you to change the colour of the text -->
          <h1><a href="Default.aspx">Internet<span class="logo_colour">Banking</span></a></h1>
          <h2>Login. View. Transfer.</h2>
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
      <div id="content">
        <!-- insert the page content here -->
        <h1>Welcome to Internet Banking</h1>
          <p>Name:</p>
          <asp:TextBox ID="TextBox1" CssClass="input" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="TextBox1" ErrorMessage="Name cannot be blank"></asp:RequiredFieldValidator><br />
          <p>Username:</p>
          <asp:TextBox ID="TextBox7" CssClass="input" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="TextBox7" ErrorMessage="Username cannot be blank"></asp:RequiredFieldValidator><br />
          <p>Password:</p>
          <asp:TextBox ID="TextBox8" CssClass="input" runat="server" TextMode="Password"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ControlToValidate="TextBox8" ErrorMessage="Password cannot be blank"></asp:RequiredFieldValidator><br />
          <p>Email:</p>
          <asp:TextBox ID="TextBox2" CssClass="input" runat="server"></asp:TextBox> <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                        ControlToValidate="TextBox2" ErrorMessage="Email cannot be blank"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                        ControlToValidate="TextBox2" ErrorMessage="Invalid Email ID" 
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator><br />
          <p>Mobile:</p>
          <asp:TextBox ID="TextBox3" CssClass="input" runat="server"></asp:TextBox> </asp:TextBox>
           <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox3" ErrorMessage="City cannot be blank"></asp:RequiredFieldValidator>
           <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox3" ErrorMessage="Invalid Mob No" 
                        MaximumValue="9999999999" MinimumValue="7000000000"></asp:RangeValidator>
           <br />
          <p>City:</p>
          <asp:TextBox ID="TextBox4" CssClass="input" runat="server"></asp:TextBox> <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                        ControlToValidate="TextBox4" ErrorMessage="City cannot be blank"></asp:RequiredFieldValidator><br />
          <p>Account No:</p>
          <asp:TextBox ID="TextBox5" CssClass="input" runat="server" OnDisposed="TextBox5_Disposed" AutoPostBack="true" OnLoad="TextBox5_Load" OnTextChanged="TextBox5_TextChanged1" OnUnload="TextBox5_Unload"></asp:TextBox><br />
          <p>Balance:</p>
          <asp:TextBox ID="TextBox6" Enabled="false" CssClass="input" runat="server"></asp:TextBox><br /><br />
          <asp:Button ID="Button1" CssClass="submit" runat="server" Text="Register" OnClick="Button1_Click" />
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
