<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Feedback.aspx.cs" Inherits="Z01_WebForms.Feedback" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <p>
        &nbsp;</p>

    <table>
        <tr>
            <td>
                <asp:Label ID="lblStudentName" runat="server" Text="Label"></asp:Label>
            </td>
            <br />
            <td>

                <asp:TextBox ID="txtStudentName" runat="server"></asp:TextBox>

            </td>

        </tr>
        <tr>
            <td>

                <asp:Label ID="lblGender" runat="server" Text="Gender"></asp:Label>

            </td>
            <td>

                <asp:RadioButtonList ID="rbtnGender" runat="server" AutoPostBack="True"></asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblCourse" runat="server" Text="Course"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="dlistCourse" runat="server" AutoPostBack="True">
                    <asp:ListItem>C#</asp:ListItem>
                    <asp:ListItem>Java</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
            </td>
            <td>
                <asp:ListBox ID="ListBox2" runat="server"></asp:ListBox>
            </td>
        </tr>
    </table>

    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    <hr />
    <asp:Label ID="lblDisplay" runat="server" Text="Label"></asp:Label>


</asp:Content>
