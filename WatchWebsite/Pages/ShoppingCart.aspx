<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ShoppingCart.aspx.cs" Inherits="Pages_ShoppingCart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <asp:Panel ID="pnlShoppingCart" runat="server" Height="307px">
        <!-- behold this Eldritch horror -->
        <!-- Ph'nglui mglw'nafh wgah'nagl fhtagn -->
    </asp:Panel>
    <table>
        <tr>
             <td>
                 <b>Total: </b> 

             </td>
             <td>
                 <asp:Literal ID="litTotal" runat="server" Text=""/>

             </td>
        </tr>

         <tr>
             <td>
                 <b>VAT: </b> 
             </td>
             <td>
                 <asp:Literal ID="litVat" runat="server" Text=""/>
             </td>
        </tr>

         <tr>
             <td>
                 <b>Shipping: </b>

             </td>
             <td>R 50</td>
        </tr>

         <tr>
             <td>
                 <b>Total Amount: </b>
             </td>
             <td>
                 <asp:Literal ID="litTotalAmount" runat="server" Text=""/>

             </td>
        </tr>
        <tr>
            <td>
                <br/>
                <!-- how to tell if a backend developer did the frontend... &nbsp; -- non-braking space. solid proof! haha -->
                <!-- relevant meme &nbsp;&nbsp;&nbsp; https://i.imgur.com/Bv86AlB.png    -->
                <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Index.aspx">Continue Shopping</asp:LinkButton> &nbsp;&nbsp;
                OR
                <asp:Button ID ="btnCheckOut" runat="server" PostBackURL ="~/Pages/Checkout.aspx" CssClass ="button" Width="250px" Text="Continue Checkout ->" />
                <br/>
            </td>

        </tr>


    </table>
      
</asp:Content>

