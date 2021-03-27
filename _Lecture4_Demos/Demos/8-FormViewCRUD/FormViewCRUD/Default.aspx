<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FormViewCRUD.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Implementing Creation, Read, Update and Delete using the FormView Data Control</h1>
            <br />
            <br />
            <asp:FormView ID="FormView1" runat="server" AllowPaging="True" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" DataKeyNames="CustomerId" DataSourceID="SqlDataSource1" ForeColor="Black">
                <EditItemTemplate>
                    CustomerId:
                    <asp:Label ID="CustomerIdLabel1" runat="server" Text='<%# Eval("CustomerId") %>' />
                    <br />
                    FirstName:
                    <asp:TextBox ID="FirstNameTextBox" runat="server" Text='<%# Bind("FirstName") %>' />
                    <br />
                    LastName:
                    <asp:TextBox ID="LastNameTextBox" runat="server" Text='<%# Bind("LastName") %>' />
                    <br />
                    CreditLimit:
                    <asp:TextBox ID="CreditLimitTextBox" runat="server" Text='<%# Bind("CreditLimit") %>' />
                    <br />
                    <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
                    &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                </EditItemTemplate>
                <EditRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                <FooterStyle BackColor="Tan" />
                <HeaderStyle BackColor="Tan" Font-Bold="True" />
                <InsertItemTemplate>
                    FirstName:
                    <asp:TextBox ID="FirstNameTextBox" runat="server" Text='<%# Bind("FirstName") %>' />
                    <br />
                    LastName:
                    <asp:TextBox ID="LastNameTextBox" runat="server" Text='<%# Bind("LastName") %>' />
                    <br />
                    CreditLimit:
                    <asp:TextBox ID="CreditLimitTextBox" runat="server" Text='<%# Bind("CreditLimit") %>' />
                    <br />
                    <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
                    &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                </InsertItemTemplate>
                <ItemTemplate>
                    CustomerId:
                    <asp:Label ID="CustomerIdLabel" runat="server" Text='<%# Eval("CustomerId") %>' />
                    <br />
                    FirstName:
                    <asp:Label ID="FirstNameLabel" runat="server" Text='<%# Bind("FirstName") %>' />
                    <br />
                    LastName:
                    <asp:Label ID="LastNameLabel" runat="server" Text='<%# Bind("LastName") %>' />
                    <br />
                    CreditLimit:
                    <asp:Label ID="CreditLimitLabel" runat="server" Text='<%# Bind("CreditLimit") %>' />
                    <br />
                    <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" CommandName="Edit" Text="Edit" />
                    &nbsp;<asp:LinkButton ID="DeleteButton" runat="server" CausesValidation="False" CommandName="Delete" Text="Delete" />
                    &nbsp;<asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" CommandName="New" Text="New" />
                </ItemTemplate>
                <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
            </asp:FormView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" DeleteCommand="DELETE FROM [Customer] WHERE [CustomerId] = @original_CustomerId AND [FirstName] = @original_FirstName AND [LastName] = @original_LastName AND [CreditLimit] = @original_CreditLimit" InsertCommand="INSERT INTO [Customer] ([FirstName], [LastName], [CreditLimit]) VALUES (@FirstName, @LastName, @CreditLimit)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [Customer]" UpdateCommand="UPDATE [Customer] SET [FirstName] = @FirstName, [LastName] = @LastName, [CreditLimit] = @CreditLimit WHERE [CustomerId] = @original_CustomerId AND [FirstName] = @original_FirstName AND [LastName] = @original_LastName AND [CreditLimit] = @original_CreditLimit">
                <DeleteParameters>
                    <asp:Parameter Name="original_CustomerId" Type="Int32" />
                    <asp:Parameter Name="original_FirstName" Type="String" />
                    <asp:Parameter Name="original_LastName" Type="String" />
                    <asp:Parameter Name="original_CreditLimit" Type="Decimal" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="FirstName" Type="String" />
                    <asp:Parameter Name="LastName" Type="String" />
                    <asp:Parameter Name="CreditLimit" Type="Decimal" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="FirstName" Type="String" />
                    <asp:Parameter Name="LastName" Type="String" />
                    <asp:Parameter Name="CreditLimit" Type="Decimal" />
                    <asp:Parameter Name="original_CustomerId" Type="Int32" />
                    <asp:Parameter Name="original_FirstName" Type="String" />
                    <asp:Parameter Name="original_LastName" Type="String" />
                    <asp:Parameter Name="original_CreditLimit" Type="Decimal" />
                </UpdateParameters>
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
