<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ValidatedCustomerForm.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        User Name:<asp:TextBox ID="TxtName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TxtName" ErrorMessage="You must enter a user name" ForeColor="#CC3300"></asp:RequiredFieldValidator>
        <br />
        Password:&nbsp;
        <asp:TextBox ID="TxtPassword" runat="server" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TxtPassword" ErrorMessage="You must enter a password" ForeColor="#CC3300"></asp:RequiredFieldValidator>
        <br />
        Password&nbsp;&nbsp;
        <asp:TextBox ID="TxtPasswordRetype" runat="server" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TxtPasswordRetype" ErrorMessage="You must confirm your password" ForeColor="#CC3300"></asp:RequiredFieldValidator>
&nbsp;
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TxtPassword" ControlToValidate="TxtPasswordRetype" ErrorMessage="Your password does not match" ForeColor="#CC3300"></asp:CompareValidator>
        <br />
        (retype)<br />
        E-mail&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TxtEmail" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TxtEmail" ErrorMessage="This email is missing the @ symbol" ForeColor="#CC3300" ValidationExpression=".+@.+"></asp:RegularExpressionValidator>
        <br />
        Age:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TxtAge" runat="server"></asp:TextBox>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TxtAge" ErrorMessage="Age must be between 0 and 120" ForeColor="#CC3300" MaximumValue="120" MinimumValue="0" Type="Integer"></asp:RangeValidator>
        &nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TxtAge" ErrorMessage="Missing age" ForeColor="#CC3300"></asp:RequiredFieldValidator>
        <br />
        <br />
        <br />
        <asp:Button ID="BtnSubmit" runat="server" OnClick="BtnSubmit_Click" Text="Submit" />
&nbsp;&nbsp;
      
        <br />
        <br />
        <asp:Label ID="LblMessage" runat="server"></asp:Label>
        <br />
    
    </div>
    </form>
</body>
</html>
