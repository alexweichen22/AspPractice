<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Opening.aspx.cs" Inherits="MultiPage.Opening" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 136px;
            height: 91px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Welcome To My Site</h1>
            <h1>
                <img alt="Chiarelli" class="auto-style1" src="images/chiarelli.jpg" />&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="LblStatus" runat="server" Text="Label"></asp:Label>
            </h1>
            <br />
            <br />
            <h2>Click here to go to <a href="Second.aspx">2nd page</a></h2>
            <br />
            <br />
            <h2>No.... Click here to go to <a href="Second.aspx">Second Page</a></h2>
            <h2>&nbsp;</h2>
            <br />
        </div>
    </form>
</body>
</html>
