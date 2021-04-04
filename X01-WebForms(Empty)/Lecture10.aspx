<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Lecture10.aspx.cs" Inherits="_L7B_EmptyWebForms2.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Check Box List</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Favorite Language<br />
            <asp:CheckBoxList ID="CBListLanguages" runat="server">
                <asp:ListItem>C#</asp:ListItem>
                <asp:ListItem>Java</asp:ListItem>
                <asp:ListItem>Javascript</asp:ListItem>
                <asp:ListItem>Python</asp:ListItem>
            </asp:CheckBoxList>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <br />
            <br />
            <asp:Label ID="LblLanguages" runat="server" Text="Favorite Languages:"></asp:Label>
        </div>
    </form>
</body>
</html>
