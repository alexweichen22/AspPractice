<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SimpleFormatting.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: "Courier New", Courier, monospace;
        }
        .auto-style2 {
            color: #FF0000;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Here&#39;s an example of some simple text formatting ... font and color</h1>
            <br />
            Here is a line of text with a different <span class="auto-style1">font</span> and <span class="auto-style2">color</span> .... here is a <a href="http://www.cnn.com">link</a> also<br />
            <br />
            This is an ASP.NET image control
            <asp:Image ID="Image1" runat="server" Height="64px" ImageUrl="~/images/internals.jpg" Width="84px" />
            <br />
        </div>
    </form>
</body>
</html>
