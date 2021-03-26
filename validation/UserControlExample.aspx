<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserControlExample.aspx.cs" Inherits="validation.UserControlExample" %>
<%@ Register Src="~/Controls/SelectTableList.ascx" TagName="WebControl" TagPrefix="TWebControl"%>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <TWebControl:WebControl Title="Fruit list" ID="Header" runat="server" />
</asp:Content>
