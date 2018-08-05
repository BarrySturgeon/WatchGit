<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Product.aspx.cs" Inherits="Pages_Product" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
        <tr>
            <td rowspan="4"> <asp:Image ID="imgProduct" runat="server" cssClass="detailsImage"/></td>
            <td> <h2>
                <asp:Label ID="lblTitle" runat="server" Text="Label"></asp:Label>
                <hr />
                 <asp:Button ID="btnAdd" runat="server" CssClass="button" OnClick="btnAdd_Click" Text="Add to Cart" />
                 </h2></td>
        </tr>   
        <tr>
            <td> <asp:Label ID="lblDescription" runat="server" CssClass="detailsDescription"></asp:Label></td>
            <td> <asp:Label ID="lblPrice" runat="server"  CssClass="detailsPrice"></asp:Label></td><br />
            Quantity : <asp:DropDownList  ID="ddlAmount" runat="server"></asp:DropDownList ><br />
            <asp:Label ID="lblResult" runat="server" Text="" ></asp:Label>
        </tr>
        <tr>
            <td> Product Number: 
            <asp:Label ID="lblItemNo" runat="server" Text="Label"></asp:Label></td>
        </tr>
        <tr>
            <td> <asp:Label ID="lblAvail" runat="server" Text="Available" CssClass="productPrice"></asp:Label></td>
        </tr>
    </table>

    <iframe src="https://www.facebook.com/plugins/like.php?href=https%3A%2F%2Fwww.facebook.com%2FTimemasters-Swiss-Timepiece-Specialists-397900387404038%2F&width=450&layout=standard&action=like&size=large&show_faces=true&share=true&height=80&appId" width="450" height="80" style="border:none;overflow:hidden" scrolling="no" frameborder="0" allowTransparency="true" allow="encrypted-media"></iframe>
    <a href="https://twitter.com/share?ref_src=twsrc%5Etfw" class="twitter-share-button" data-show-count="false">Tweet</a><script async src="https://platform.twitter.com/widgets.js" charset="utf-8"></script>


</asp:Content>

