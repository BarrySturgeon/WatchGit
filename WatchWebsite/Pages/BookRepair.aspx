<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="BookRepair.aspx.cs" Inherits="Pages_BookRepair" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:Panel ID="pnlBookRepair" runat="server">
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label runat="server" Font-Size="XX-Large" text="Want to get your watch fixed? No problem!"></asp:Label>
        <br />

    </asp:Panel>
    <table>
        <tr>
            <td>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

                <asp:label runat="server" text="Just click on the issue you're having and we'll develope an estimated repair fee to fix your watch" Font-Size="Large"></asp:label>

                <br />

                <br />

                <asp:checkboxlist ID="chBox" runat="server" >

                    <asp:ListItem Text="Cracked/damaged watch face" Value=500></asp:ListItem>
                    <asp:ListItem Text="Water damage" Value=200></asp:ListItem>
                    <asp:ListItem Text="Hands not moving/battery issues" Value=300></asp:ListItem>
                    <asp:ListItem Text="Broken strap" Value=150></asp:ListItem>
                    <asp:ListItem Text="Mechanical issues" Value=500></asp:ListItem>

                </asp:checkboxlist>

                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

                <br />

                <br />
                <br />

                <asp:Button ID="btnSub" Font-size="Larger" runat="server" Text="Submit" OnClick="btnSub_Click" />


                <br />
                <br />


                <asp:Label ID="lbResult" Font-size="Larger" runat="server" Text=""></asp:Label>

                <br />
            </td>
        
        </tr>


    </table>

</asp:Content>

