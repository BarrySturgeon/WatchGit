<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Management.aspx.cs" Inherits="Pages_Management_Management" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:LinkButton ID="LinkButton1" runat="server" CssClass="button" PostBackUrl="~/Pages/Management/ManageProducts.aspx">Add New Product</asp:LinkButton>
    <br />
    <br />
    <asp:GridView ID="grdProducts" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="sdsProducts" AllowPaging="True" AllowSorting="True" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" Height="100%" Width="100%">
        <AlternatingRowStyle BackColor="#CCCCCC" />
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" DataFormatString="{0:D}" />
            <asp:TemplateField HeaderText="TypeId" SortExpression="TypeId">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server" onkeydown ="return (!(event.keyCode>=65) && event.keyCode!=32);" Text='<%# Bind("TypeId") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("TypeId", "{0:D}") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            <asp:TemplateField HeaderText="Price" SortExpression="Price">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox2" runat="server" onkeydown ="return (!(event.keyCode>=65) && event.keyCode!=32);" Text='<%# Bind("Price") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("Price", "{0:C2}") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
            <asp:BoundField DataField="Image" HeaderText="Image" SortExpression="Image" />
            <asp:TemplateField HeaderText="Quantity" SortExpression="Quantity">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox3" runat="server" onkeydown ="return (!(event.keyCode>=65) && event.keyCode!=32);" Text='<%# Bind("Quantity") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("Quantity", "{0:D}") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:CheckBoxField DataField="isAvailable" HeaderText="isAvailable" SortExpression="isAvailable"/>
            <asp:CheckBoxField DataField="isVisible" HeaderText="isVisible" SortExpression="isVisible" />
            <asp:TemplateField HeaderText="BranchId" SortExpression="BranchId">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox4" runat="server" onkeydown ="return (!(event.keyCode>=65) && event.keyCode!=32);" Text='<%# Bind("BranchId") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label4" runat="server" Text='<%# Bind("BranchId", "{0:D}") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <FooterStyle BackColor="#CCCCCC" />
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#808080" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#383838" />
    </asp:GridView>
    <asp:SqlDataSource ID="sdsProducts" runat="server" ConnectionString="<%$ ConnectionStrings:WatchDBv2ConnectionString %>" DeleteCommand="DELETE FROM [Product] WHERE [Id] = @Id" InsertCommand="INSERT INTO [Product] ([TypeId], [Name], [Price], [Description], [Image], [Quantity], [isAvailable], [isVisible], [BranchId]) VALUES (@TypeId, @Name, @Price, @Description, @Image, @Quantity, @isAvailable, @isVisible, @BranchId)" SelectCommand="SELECT [Id], [TypeId], [Name], [Price], [Description], [Image], [Quantity], [isAvailable], [isVisible], [BranchId] FROM [Product]" UpdateCommand="UPDATE [Product] SET [TypeId] = @TypeId, [Name] = @Name, [Price] = @Price, [Description] = @Description, [Image] = @Image, [Quantity] = @Quantity, [isAvailable] = @isAvailable, [isVisible] = @isVisible, [BranchId] = @BranchId WHERE [Id] = @Id">
        <DeleteParameters>
            <asp:Parameter Name="Id" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="TypeId" Type="Int32" />
            <asp:Parameter Name="Name" Type="String" />
            <asp:Parameter Name="Price" Type="Double" />
            <asp:Parameter Name="Description" Type="String" />
            <asp:Parameter Name="Image" Type="String" />
            <asp:Parameter Name="Quantity" Type="Int32" />
            <asp:Parameter Name="isAvailable" Type="Boolean" />
            <asp:Parameter Name="isVisible" Type="Boolean" />
            <asp:Parameter Name="BranchId" Type="Int32" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="TypeId" Type="Int32" />
            <asp:Parameter Name="Name" Type="String" />
            <asp:Parameter Name="Price" Type="Double" />
            <asp:Parameter Name="Description" Type="String" />
            <asp:Parameter Name="Image" Type="String" />
            <asp:Parameter Name="Quantity" Type="Int32" />
            <asp:Parameter Name="isAvailable" Type="Boolean" />
            <asp:Parameter Name="isVisible" Type="Boolean" />
            <asp:Parameter Name="BranchId" Type="Int32" />
            <asp:Parameter Name="Id" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
    <br />
    <br />
    <asp:LinkButton ID="LinkButton2" runat="server" CssClass="button" PostBackUrl="~/Pages/Management/ManageProductTypes.aspx">Add New Product Type</asp:LinkButton>
    <br />
    <asp:GridView ID="grdProductsType" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="sdsProductTypes" Width="100%" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical">
        <AlternatingRowStyle BackColor="#CCCCCC" />
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
        </Columns>
        <FooterStyle BackColor="#CCCCCC" />
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#808080" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#383838" />
    </asp:GridView>
    <asp:SqlDataSource ID="sdsProductTypes" runat="server" ConnectionString="Data Source=LOCALHOST\SQLEXPRESS01;Initial Catalog=WatchDBv2;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework" DeleteCommand="DELETE FROM [ProductTypes] WHERE [Id] = @Id" InsertCommand="INSERT INTO [ProductTypes] ([Name]) VALUES (@Name)" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [ProductTypes]" UpdateCommand="UPDATE [ProductTypes] SET [Name] = @Name WHERE [Id] = @Id">
        <DeleteParameters>
            <asp:Parameter Name="Id" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="Name" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="Name" Type="String" />
            <asp:Parameter Name="Id" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
    <br />
    <div id="UploadImagediv">
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <asp:Button ID="UploadButton" class="button" runat="server" Text="Upload Image" OnClick="Button1_Click" />
        <br />
        <asp:Label ID="lblUploadMessage" runat="server" Font-Bold="true"></asp:Label>
        <br />
        <br />
    </div>
</asp:Content>

