<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Pages_Account_Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div id="regDiv">
    <p>
        <asp:Literal ID="litStatus" runat="server" ViewStateMode="Enabled"></asp:Literal>
        
    </p>
    <p>
        <asp:Label ID="StatusLabel" runat="server" Text="" ViewStateMode="Enabled"></asp:Label>
    </p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Username: " Width="20%"></asp:Label>
        <asp:TextBox ID="txtUsrName" runat="server" CssClass="inputs" Width="20%"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" Text="Password: " Width="20%"></asp:Label>
        &nbsp;<asp:TextBox ID="txtPassword" runat="server" CssClass="inputs" TextMode="Password" Width="20%" ></asp:TextBox>
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label3" runat="server" Text="Confirm Password:" Width="14%"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtConfirmPassword" runat="server" CssClass="inputs" TextMode="Password" Width="20%" OnTextChanged="txtConfirmPassword_TextChanged"></asp:TextBox>
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label6" runat="server" Text="Email: "></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtEmail" runat="server" CssClass="inputs" TextMode="Email" Width="20%"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label4" runat="server" Text="First Name:"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtFirstName" runat="server" CssClass="inputs" Width="20%"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="txtLastName" runat="server" Text="Last Name:"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="textLastName" CssClass="inputs" runat="server" Width="20%"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label5" runat="server" Text="Address"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtAddress" runat="server" CssClass="inputs" Height="63px" TextMode="MultiLine" Width="20%"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" CssClass="button" Text="Register" OnClick="Button1_Click" />
    </p>
        </div>
</asp:Content>

