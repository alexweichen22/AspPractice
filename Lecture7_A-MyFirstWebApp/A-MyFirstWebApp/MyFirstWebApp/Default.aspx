<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MyFirstWebApp.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        What is your first name ?&nbsp;
        <asp:TextBox ID="TxtFirstName" runat="server"></asp:TextBox>
        <br />
        <br />
        What is your last name ?&nbsp;
        <asp:TextBox ID="TxtLastName" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="BtnOk" runat="server" OnClick="BtnOk_Click" Text="Click Me" />
        <br />
        <br />
        <hr />
        <br />
        <br />
        <asp:Label ID="LblResult" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
