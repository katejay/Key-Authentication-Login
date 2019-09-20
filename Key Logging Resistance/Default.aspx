<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>simplestyle_7</title>
  <meta name="description" content="website description" />
  <meta name="keywords" content="website keywords, website keywords" />
  <meta http-equiv="content-type" content="text/html; charset=windows-1252" />
  <link rel="stylesheet" type="text/css" href="http://fonts.googleapis.com/css?family=Tangerine&amp;v1" />
  <link rel="stylesheet" type="text/css" href="http://fonts.googleapis.com/css?family=Yanone+Kaffeesatz" />
    <style>


td:hover{
background: -moz-linear-gradient(top,#249ee4,#057cc0);
background: -webkit-gradient(linear,0%0%,0%100%,from(#249ee4),to(#057cc0));
    }

td:active
    {
background: -moz-linear-gradient(top,#057cc0,#249ee4);
background: -webkit-gradient(linear,0%0%,0%100%,from(#057cc0),to(#249ee4));
    }

#result{
font-weight:bold;
font-size:16pt;
    }
</style>
<!--JAVASCRIPT -->
<script src="Scripts/jquery-2.2.0.min.js"></script>
<script>
    function message()
    {
        alert('REGISTER SUCCESSFULL');
    }
    $(document).ready(function () {
        $("#myTable td").click(function () {

            var column_num = parseInt($(this).index()) ;
            var row_num = parseInt($(this).parent().index()) ;
            var str = $("#result1").val();

            $("#result1").val(str + row_num + "," + column_num + "_");
            $("#result2").append(row_num + "," + column_num + "_");
        });

    });
    function Clear() {
        $("#result1").html("");
        $("#result2").html("");
    }
</script>
  <link rel="stylesheet" type="text/css" href="style/style.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <div id="main">
    <div id="header">
      <div id="logo">
        <div id="logo_text">
          <!-- class="logo_colour", allows you to change the colour of the text -->
          <h1><a href=" ">Key Logging for <span class="logo_colour">Banking</span></a></h1>
          <h2></h2>
        </div>
      </div>
      <div id="menubar">
        <ul id="menu">
          <!-- put class="selected" in the li tag for the selected page - to highlight which page you're on -->
          <li><a href="Registration.aspx">Registration</a></li>
             <li class="selected"><a href="Default.aspx">Login</a></li>
          
         
        </ul>
      </div>
    </div>
    <div id="site_content">
      
       
      <div class="sidebar">
        <!-- insert your sidebar items here -->
        
      <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
          
      </div>
      <div id="content">
        <!-- insert the page content here -->
        
            <h1>Login
          </h1>
      
     <p>Username</p>
          <asp:TextBox CssClass="input" ID="TextBox1" runat="server"></asp:TextBox>
          <br />
          <br />
          <asp:Button ID="Button1" runat="server" Text="Next" OnClick="Button1_Click" Width="106px" />
         
          <asp:Table ID="Table1" Visible="false" runat="server"  Height="161px" Width="275px">
          </asp:Table>
  <!--Code for get index of row and column-->
          <asp:Panel ID="Panel1" runat="server">
          <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
<asp:UpdatePanel ID="UpdatePanel1" UpdateMode="Conditional" ChildrenAsTriggers="false" runat="server">
<ContentTemplate>


<label onclick="Clear()">clear</label>
    <style>
        td{
            border-bottom-color:black;
            border-color:black;
            width:60px;
            height:40px;
        }
    </style>
<input type="hidden" runat="server" id="result1" enableviewstate="true"/>
<div id="result2" runat="server"></div>
<table id="myTable" border="1" style="border-collapse: collapse;" cellpadding="8">
<!--1st ROW-->
<tr>
<td></td>
<td></td>
<td></td>
<td></td>
<td></td><td></td>
</tr>

<!--2nd ROW-->
<tr>
<td></td>
<td></td>
<td></td>
<td></td>
<td></td><td></td>
</tr>

<!--3rd ROW-->
<tr>
<td></td>
<td></td>
<td></td>
<td></td>
<td></td><td></td>
</tr>

<!--4th ROW-->
<tr>
<td></td>
<td></td>
<td></td>
<td></td>
<td></td><td></td>
</tr>

<!--5th ROW-->
<tr>
<td></td>
<td></td>
<td></td>
<td></td>
<td></td><td></td>
</tr>
    <tr>
<td></td>
<td></td>
<td></td>
<td></td>
<td></td><td></td>
</tr>
</table>
<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Submit"/>
    <asp:Label ID="Label1" runat="server" ForeColor="Red" Text=""></asp:Label>
</ContentTemplate>
    <Triggers>
        <asp:PostBackTrigger ControlID="Button2"  />
    </Triggers>
</asp:UpdatePanel></asp:Panel>
          
          <!--ENd OF Code-->
      
           

          </div>
     </div>
    <div id="footer1">
        Copyright &copy; BHARTI VIDYAPEETH
    </div>
        </div>
                </div>
       
    </form>
</body>
</html>
