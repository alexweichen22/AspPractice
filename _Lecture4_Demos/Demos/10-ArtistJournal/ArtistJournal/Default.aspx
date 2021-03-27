<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ArtistJournal.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Artist Journals Search Page</h1>
            <br />
            Start Date:
            <asp:TextBox ID="TxtStart" runat="server"></asp:TextBox>
            <br />
            <br />
            End Date:
            <asp:TextBox ID="TxtEnd" runat="server"></asp:TextBox>
            <br />
            <br />
            Type dates or use the calendar to select dates:<br />
            <br />
            <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
            <br />
            <asp:Button ID="BtnFind" runat="server" Text="Find Journals (use when manually typing in dates)" />
            <br />
            <br />
            <asp:Button ID="BtnClear" runat="server" OnClick="BtnClear_Click" Text="Clear Dates ... Start New Search" />
            <br />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="IDNumber,JournalDate" DataSourceID="SqlDataSource1" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2">
                <Columns>
                    <asp:BoundField DataField="IDNumber" HeaderText="IDNumber" ReadOnly="True" SortExpression="IDNumber" />
                    <asp:BoundField DataField="JournalDate" HeaderText="JournalDate" ReadOnly="True" SortExpression="JournalDate" />
                    <asp:BoundField DataField="Remarks" HeaderText="Remarks" SortExpression="Remarks" />
                </Columns>
                <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#FFF1D4" />
                <SortedAscendingHeaderStyle BackColor="#B95C30" />
                <SortedDescendingCellStyle BackColor="#F1E5CE" />
                <SortedDescendingHeaderStyle BackColor="#93451F" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [ArtistJournal] WHERE (([JournalDate] >= ?) AND ([JournalDate] <= ?))">
                <SelectParameters>
                    <asp:ControlParameter ControlID="TxtStart" Name="JournalDate" PropertyName="Text" Type="DateTime" />
                    <asp:ControlParameter ControlID="TxtEnd" Name="JournalDate2" PropertyName="Text" Type="DateTime" />
                </SelectParameters>
            </asp:SqlDataSource>
            <br />
        </div>
    </form>
</body>
</html>
