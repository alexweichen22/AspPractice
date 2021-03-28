<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PostalCalculator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Postal Calculator<br />
        <br />
        Width&nbsp;
        <asp:TextBox ID="TxtWidth" runat="server"></asp:TextBox>
        <br />
        Height&nbsp;
        <asp:TextBox ID="TxtHeight" runat="server"></asp:TextBox>
        <br />
        Length&nbsp;
        <asp:TextBox ID="TxtLength" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:RadioButton ID="RdoGround" runat="server" AutoPostBack="True" GroupName="DeliveryMode" OnCheckedChanged="RdoGround_CheckedChanged" Text="Ground" />
        &nbsp;(.15 multiplier)<br />
        <asp:RadioButton ID="RdoAir" runat="server" AutoPostBack="True" GroupName="DeliveryMode" OnCheckedChanged="RdoAir_CheckedChanged" Text="Air" />
        &nbsp;(.25 multiplier)<br />
        <asp:RadioButton ID="RdoNextDay" runat="server" AutoPostBack="True" GroupName="DeliveryMode" OnCheckedChanged="RdoNextDay_CheckedChanged" Text="Next Day" />
        &nbsp;(.45 multiplier)<br />
        <br />
        <asp:Label ID="LblResult" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
