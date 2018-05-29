<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="testpage.aspx.cs" Inherits="Pages_testpage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    <asp:Button ID="Button1" runat="server" Text="make 404 error" OnClick="Button1_Click" />
        </p><p>
    <asp:Button ID="Button2" runat="server" Text="make unauthorized error" OnClick="Button2_Click" />
            </p><p>
    <asp:Button ID="Button3" runat="server" Text="make internal server error " OnClick="Button3_Click" />
                </p><p>
                    <asp:Button ID="Button4" runat="server" Text="test certain functionality" OnClick="Button4_Click" />
                    </p>
</asp:Content>

