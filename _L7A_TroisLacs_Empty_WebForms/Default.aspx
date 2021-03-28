<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_L7A_TroisLacs_Empty_WebForms.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>_L7_TroisLacs-firstWebForm</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Welcome to TroisLacs&#39;s first real ASP.NET web apps</h1>
            <p>
                &nbsp;</p>
            
                Enter FirstName:<asp:TextBox ID="TxtFirstName" runat="server"></asp:TextBox>
            
            
                <br />
            <br />
            
            
                Enter LastName:<asp:TextBox ID="TxtLastName" runat="server"></asp:TextBox>
            
            
                <br />
            <br />
            
            
                <asp:Button ID="BtnSubmit" runat="server" Text="Submit" OnClick="BtnSubmit_Click" />
            
            
                <br />
            <br />
            
            <hr />
                <asp:Label ID="LblDisplay" runat="server" Text="[Display]"></asp:Label>
            

        </div>
    </form>
</body>
</html>
