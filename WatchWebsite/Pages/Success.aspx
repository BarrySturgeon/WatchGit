<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Success.aspx.cs" Inherits="Pages_Success" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="Label1" runat="server" Font-Size="X-Large" Text="Thank you for your purchase!"></asp:Label>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Your payment has been recieved"></asp:Label>
</asp:Content>

