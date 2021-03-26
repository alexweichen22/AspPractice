<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="validation.Registration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-md-4">
            <asp:Label ID="Label1" runat="server" Text="Enter your Email id:"></asp:Label>
            <asp:TextBox ID="txtId" runat="server" Width="193px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorID" runat="server" ErrorMessage="You need to enter the ID" ControlToValidate="txtId" BorderStyle="Dotted" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>

            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ErrorMessage="The email needs to valid" runat="server" ControlToValidate="txtId" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>

        </div>

        <div class="col-md-4">
            <asp:Label ID="Label2" runat="server" Text="Password" Width="122px"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" Width="197px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorID0" runat="server" ErrorMessage="You need to enter the password" ControlToValidate="TextBox1" BorderStyle="Dotted" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>

        </div>
        <div class="col-md-4">
            <asp:Label ID="Label3" runat="server" Text="Re-type Password" Width="122px"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" Width="197px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorID1" runat="server" ErrorMessage="You need to enter the password again" ControlToValidate="TextBox2" BorderStyle="Dotted" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>

            <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Passwords are not the same" ControlToCompare="TextBox1" ForeColor="#FF3300" ControlToValidate="TextBox2"></asp:CompareValidator>

        </div>
        <div class="col-md-4">

            <asp:Label ID="Label4" runat="server" Text="Age" Width="122px"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" Width="194px"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="The age needs to be between 10 and 80" ControlToValidate="TextBox3" MaximumValue="80" MinimumValue="10"></asp:RangeValidator>
        </div>
    
    </div>


    <br />

    <asp:CustomValidator ID="CustomValidator1" runat="server" 
        ErrorMessage="User ID should have atleast a capital, small and digit and should be greater than 5 and less  
than 26 letters" OnServerValidate="CustomValidator1_ServerValidate" ControlToValidate="txtId"></asp:CustomValidator>

    <br />
    <asp:Button ID="btnSubmit" runat="server" Text="Submit" />
    <br />
</asp:Content>
