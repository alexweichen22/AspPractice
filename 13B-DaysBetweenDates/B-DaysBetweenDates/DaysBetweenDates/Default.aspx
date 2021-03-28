<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DaysBetweenDates.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        How many days have elapsed<br />
        <br />
        Choose first date:<br />
        <asp:Calendar ID="CalOne" runat="server"></asp:Calendar>
        <br />
        Choose second date:<br />
    
    </div>
        <asp:Calendar ID="CalTwo" runat="server"></asp:Calendar>
        <br />
        <asp:Button ID="BtnOK" runat="server" OnClick="BtnOK_Click" Text="OK" />
        <br />
        <br />
        Days elapsed: <asp:Label ID="LblResult" runat="server"></asp:Label>
        <br />
    </form>
</body>
</html>
