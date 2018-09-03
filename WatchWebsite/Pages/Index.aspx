<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Pages_Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div>
        <asp:TextBox runat="server" Width="640px"></asp:TextBox>
        <asp:Button runat="server" Text="Search" ID="SearchBtn" OnClick="SearchBtn_Click" />
     </div>
    <asp:Panel ID="pnlProducts" runat="server">
    </asp:Panel>
    <div style ="clear: both">

    </div>
</asp:Content>

