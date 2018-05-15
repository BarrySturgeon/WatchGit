<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Pages_Account_Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <asp:Label ID="Label1" runat="server" Text="Username: " Width="20%"></asp:Label>
        <asp:TextBox ID="txtUsrName" runat="server" CssClass="inputs" Width="20%"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" Text="Password: " Width="20%"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" CssClass="inputs" TextMode="Password" Width="20%"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label3" runat="server" Text="Confirm Password:" Width="20%"></asp:Label>
        <asp:TextBox ID="txtConfirmPassword" runat="server" CssClass="inputs" TextMode="Password" Width="20%"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" CssClass="button" Text="Button" OnClick="Button1_Click" />
    </p>
</asp:Content>

