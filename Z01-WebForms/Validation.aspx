<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Validation.aspx.cs" Inherits="Z01_WebForms.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
        Name:<asp:TextBox ID="TboxName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorName" runat="server" ErrorMessage="Missing Name" ControlToValidate="TboxName"></asp:RequiredFieldValidator>
    </p>
    <p>
        Password:<asp:TextBox ID="TboxPassword" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorPass" runat="server" ControlToValidate="TboxPassword" ErrorMessage="Password Not Set"></asp:RequiredFieldValidator>
    </p>
    <p>
        Re-Type Password:<asp:TextBox ID="TboxRePassword" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorRePass" runat="server" ControlToValidate="TboxRePassword" ErrorMessage="Retype Password Not Set"></asp:RequiredFieldValidator>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TboxPassword" ControlToValidate="TboxRePassword" ErrorMessage="Passwords Don't Match"></asp:CompareValidator>
    </p>
    <p>
        Email:<asp:TextBox ID="TboxEmail" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TboxEmail" ErrorMessage="RegularExpressionValidator" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
    </p>
    <p>
        Age:<asp:TextBox ID="TboxAge" runat="server"></asp:TextBox>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TboxAge" ErrorMessage="Age between 0 - 100" ForeColor="#FF0066" MaximumValue="100" MinimumValue="0" Type="Integer"></asp:RangeValidator>
    </p>
    <p>
        <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="TboxName" ErrorMessage="CustomValidator" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    </p>
</asp:Content>
