<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="BookRepair.aspx.cs" Inherits="Pages_BookRepair" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    
    <div style="border-style:solid; background-color:white; border-color:saddlebrown;border-radius:15px; border-width:medium">


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

                &nbsp;<br />
&nbsp;<asp:label runat="server" text="(DISCLAIMER: These prices are not final until the watch has been seen and the issue found, this serves as an estimation and not the final price.)" Font-Size="Medium" ID="label1"></asp:label>

                <br />

                <br />

                <br />
&nbsp;&nbsp;&nbsp;&nbsp;

                <asp:checkboxlist ID="chBox" runat="server" CellPadding="8" CellSpacing="5" >

                    <asp:ListItem Text="Cracked/damaged watch face" Value=500></asp:ListItem>
                    <asp:ListItem Text="Water damage" Value=200></asp:ListItem>
                    <asp:ListItem Text="Hands not moving/battery issues" Value=300></asp:ListItem>
                    <asp:ListItem Text="Broken strap" Value=150></asp:ListItem>
                    <asp:ListItem Text="Mechanical issues" Value=500></asp:ListItem>

                </asp:checkboxlist>

                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

                <br />

                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

                <br />

                <br />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

                <asp:Button ID="btnSub" Font-size="Larger" runat="server" Text="Submit" OnClick="BtnSub_Click" />


                <br />
                <br />


                <asp:Label ID="lbResult" Font-size="Larger" runat="server" Text=""></asp:Label>

                <br />
            </td>
        
        </tr>


    </table>
        </div>
       

</asp:Content>

