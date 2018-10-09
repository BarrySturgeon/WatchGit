<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Order.aspx.cs" Inherits="Pages_Order" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:Button ID="FunkButton" runat="server" CssClass="button" Text="Confirm checkout" OnClick="FunkButton_Click" />
    
</asp:Content>

