<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Lecture9A.aspx.cs" Inherits="_L7B_EmptyWebForms2.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Employee Information<br />
            <br />
            Name:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            Select Office:
            <asp:DropDownList ID="DListCity" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem>Pick City</asp:ListItem>
                <asp:ListItem>Toronto</asp:ListItem>
                <asp:ListItem>NewYork</asp:ListItem>
                <asp:ListItem>London</asp:ListItem>
                <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
            <asp:Label ID="LblCity" runat="server" Text="[City Not Chosen]"></asp:Label>
            <br />
            <br />
            <br />
            Gender (By Radio Button List)<br />
            <asp:RadioButtonList ID="RBListGender" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
                <asp:ListItem>Others</asp:ListItem>
                <asp:ListItem>Would Rather Not To Say</asp:ListItem>
            </asp:RadioButtonList>
            <asp:Label ID="LblGender" runat="server" Text="[Gender Not Chosen]"></asp:Label>
            <br />
            <br />
            Age Group (By Radio Button)<br />
            <asp:RadioButton ID="RBtnJunior" runat="server" AutoPostBack="True" GroupName="AgeGruop" OnCheckedChanged="RBtnJunior_CheckedChanged" Text="&lt;18" />
            <br />
            <asp:RadioButton ID="RBtnAdult" runat="server" AutoPostBack="True" GroupName="AgeGruop" OnCheckedChanged="RBtnAdult_CheckedChanged" Text="18-65" />
            <br />
            <asp:RadioButton ID="RBtnSenior" runat="server" AutoPostBack="True" GroupName="AgeGruop" OnCheckedChanged="RBtnSenior_CheckedChanged" Text="&gt;65" />
            <br />
            <asp:Label ID="LblAgeGroup" runat="server" Text="Age Group: TBD"></asp:Label>
            <br />
            <br />
            WorkShift (By CheckBox)<br />
            <asp:CheckBox ID="CBoxDay" runat="server" AutoPostBack="True" OnCheckedChanged="CBoxDay_CheckedChanged" Text="Day Shift" />
            <br />
            <asp:CheckBox ID="CBoxNight" runat="server" AutoPostBack="True" OnCheckedChanged="CBoxNight_CheckedChanged" Text="Night Shift" />
            <br />
            <asp:Label ID="LblWorkShifts" runat="server" Text="Shifts: TBD"></asp:Label>
            <br />
            <br />
            Emoj:<br />
            <asp:DropDownList ID="DDListEmoji" runat="server" AutoPostBack="True"  OnSelectedIndexChanged="DDListEmoji_SelectedIndexChanged" Width="139px">
                <asp:ListItem>Emojis</asp:ListItem>
                <asp:ListItem>Happy</asp:ListItem>
                <asp:ListItem>Scary</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <br />
            <br />
            <asp:Image ID="ImgEmoji" runat="server" Height="64px" Width="96px" />
        </div>
    </form>
</body>
</html>
