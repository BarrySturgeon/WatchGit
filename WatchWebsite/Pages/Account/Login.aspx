<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Pages_Account_Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <p>
        <asp:Literal ID="litStatus" runat="server"></asp:Literal>
    </p>
    <p>
        <asp:Label ID="Label4" runat="server" Text="Username: " Width="20%"></asp:Label>
        <asp:TextBox ID="txtUsrName" runat="server" CssClass="inputs" Width="20%"></asp:TextBox>
    </p>
    <!-- pointless comment -->
    <p>
        <asp:Label ID="Label5" runat="server" Text="Password: " Width="20%"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" CssClass="inputs" TextMode="Password" Width="20%"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button2" runat="server" CssClass="button" Text="Login" OnClick="Button2_Click" />
    </p>
</asp:Content>

