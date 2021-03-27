<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    Welcome
</asp:Content>

<asp:Content ID="Content3" runat="server" 
    contentplaceholderid="ContentPlaceHolder2">

    
    <p>
        This is an experimental site created using Microsoft&#39;s Visual Studio. All the pages are written using&nbsp; ASP.NET. A major component of this Udemy 
        course involves creating dynamic websites using ASP.NET. so this site will be 
        the main repository of examples which illustrate many of the concepts that will 
        be covered in class. Additionally the other main topics in the course have pages 
        dedicated to them.</p>


</asp:Content>


<asp:Content ID="Content4" runat="server" 
    contentplaceholderid="ContentPlaceHolder4">

    <center>
    <asp:Panel ID="Panel1" runat="server" Height="92px" Width="231px" Visible="False">
        <table style="width: 100%">
            <tr>
                <td rowspan="3">
                    <img alt="" src="images/chiarelli.jpg" /></td>
                <td style="height: 17px">
                    Enter Your Name Here
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="TxtName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="BtnGotoAbout" runat="server" Height="22px" 
                        onclick="BtnGotoAbout_Click" Text="Goto About Page" Width="122px" />
                </td>
            </tr>
        </table>
    </asp:Panel>
    </center>

</asp:Content>



<asp:Content ID="Content5" runat="server" 
    contentplaceholderid="ContentPlaceHolder3">

    <asp:RadioButton ID="RdoOn" runat="server" AutoPostBack="True" 
        GroupName="Image" oncheckedchanged="RdoOn_CheckedChanged" 
        Text="Image and Login On" Visible="False" /><br />
    <asp:RadioButton ID="RdoOff" runat="server" AutoPostBack="True" 
        GroupName="Image" oncheckedchanged="RdoOff_CheckedChanged" 
        Text="Image and Login Off" Visible="False" />

</asp:Content>




