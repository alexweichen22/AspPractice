<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_L7B_EmptyWebForms2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: "Arial Unicode MS";
        }
        .auto-style2 {
            color: #FF0066;
        }
    </style>
</head>
<body id="L7B-empty-WebFormsTest">
    <form id="form1" runat="server">
        <div>
            Some text here<br />
            <asp:Label ID="LblPage1" runat="server" Text="Good Day!"></asp:Label>
            <br />
            and also here to change <span class="auto-style2">color</span> and <span class="auto-style1">font</span><br />
            <br />
            Configure from &quot;Format &gt;&gt;&gt; Convert Hyper Link&quot; click here to go to <a href="http://cnn.com" target="_blank">CNN</a><br />
            <br />
            Image control by ASP (ImageURL):<br />
            <br />
            <asp:Image ID="Image1" runat="server" Height="80px" ImageUrl="~/images/images1.jpg" Width="75px" />
            <br />
            <br />
            Click <a href="Page2.aspx">here</a> to go to page 2<br />
            <br />
            <a href="Page2.aspx">Page2.aspx</a><br />
        </div>
    </form>
</body>
</html>
