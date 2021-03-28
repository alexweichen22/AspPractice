<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HelpMethods.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Convert to Cups<br />
        <br />
        <asp:TextBox ID="TxtQuantity" runat="server" ></asp:TextBox>
        <br />
        <br />
        <asp:RadioButton ID="RdoCups" runat="server" AutoPostBack="True" GroupName="Measure" OnCheckedChanged="RdoCups_CheckedChanged" Text="Cups" />
        <br />
        <asp:RadioButton ID="RdoPints" runat="server" AutoPostBack="True" GroupName="Measure" OnCheckedChanged="RdoPints_CheckedChanged" Text="Pints" />
        <br />
        <asp:RadioButton ID="RdoQuarts" runat="server" AutoPostBack="True" GroupName="Measure" OnCheckedChanged="RdoQuarts_CheckedChanged" Text="Quarts" />
        <br />
        <asp:RadioButton ID="RdoGallons" runat="server" AutoPostBack="True" GroupName="Measure" OnCheckedChanged="RdoGallons_CheckedChanged" Text="Gallons" />
        <br />
        <br />
        <asp:Label ID="LblResult" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
