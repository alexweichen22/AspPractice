<%@ Page Title="" Language="C#"  MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PersonalInfo.aspx.cs" Inherits="session_one.PersonalInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="lblWelcome" runat="server"></asp:Label>
    
    <table id="tbl" runat="server" style="padding:10px; height: 60px;" class="nav-justified">
        <tr>
            <td style="height:49px">
                <asp:Label ID="lblFirstName" runat="server" Text="First Name"></asp:Label>
            </td>
            <td style="height: 49px">
                <asp:TextBox ID="txtFirstName" runat="server" style="margin-left: 0" Height="48px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label  ID="lblLastName" runat="server" Text="Last Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtLastName" runat="server" Height="71px"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td></td>
            <td>
                <asp:Button ID="BtnSubmit" runat="server" Text="SUBMIT" OnClick="BtnSubmit_Click"/>
            </td>
        </tr>
    </table>
    <asp:Label ID="lblResult" runat="server"></asp:Label>
    <input id="Reset1" style="width: 246px" type="reset" value="reset" runat="server" />
</asp:Content>

<script runat="server">
//protected void BtnSubmit_Click(object sender, EventArgs e)
//    {
//        string firstName = txtFirstName.Text;
//        string lastName = txtLastName.Text;

//        lblResult.Text = string.Format("The personal info {0} , {1}", firstName, lastName);
//    }
</script>
