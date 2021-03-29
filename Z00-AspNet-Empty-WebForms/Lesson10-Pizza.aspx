<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Lesson10-Pizza.aspx.cs" Inherits="_L7B_EmptyWebForms2.Lesson10_Pizza" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Pizza Store</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Choice:<asp:CheckBoxList ID="CBListChoice" runat="server">
                <asp:ListItem Value="1.5">Pepperoni $1.5</asp:ListItem>
                <asp:ListItem Value="0.5">Onion $0.5</asp:ListItem>
                <asp:ListItem Value="1.0">Red Pepper $1.0</asp:ListItem>
            </asp:CheckBoxList>
            <br />
            <br />
            <br />
            Size<br />
            <asp:RadioButton ID="RBtnRegular" runat="server" Text="Regular Size $5.0" />
            <br />
            <asp:RadioButton ID="RBtnXLarge" runat="server" Text="Extra Large $7.5" />
            <br />
            <asp:Button ID="BtnPurchase" runat="server" OnClick="BtnPurchase_Click" Text="Purchase" />
            <br />
            <asp:Label ID="LblTotal" runat="server" Text="Total: "></asp:Label>
        </div>
    </form>
</body>
</html>
