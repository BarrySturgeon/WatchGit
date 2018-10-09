<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Checkout.aspx.cs" Inherits="Pages_Order" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    <h2>Enter shipping address</h2>
    <div>
        <p>
        <asp:Label ID="Label1" runat="server" Text="Full name: "></asp:Label>
        </p>

        <p>
        <asp:TextBox ID="NameTxt" runat="server"></asp:TextBox>
        </p>

        <p>
        <asp:Label ID="Label2" runat="server" Text="Address line 1: "></asp:Label>
        </p>

        <p>
        <asp:TextBox ID="AddrTxt1" runat="server"></asp:TextBox>
         </p>
        <p>
        <asp:Label ID="Label3" runat="server" Text="Address line 2: "></asp:Label>
            </p>
        <p>
        <asp:TextBox ID="AddrTxt2" runat="server"></asp:TextBox>
        </p><p>
        <asp:Label ID="Label4" runat="server" Text="City: "></asp:Label>
            </p>
        <p>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </p><p>
        <asp:Label ID="Label5" runat="server" Text="ZIP/Postal Code: "></asp:Label>
            </p><p>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </p><p>
        <asp:Label ID="Label6" runat="server" Text="Province: "></asp:Label>
            </p><p>
        <asp:DropDownList ID="ProvinceDDL" runat="server"></asp:DropDownList>
                </p><p>
        <asp:Label ID="Label7" runat="server" Text="Country: "></asp:Label>
            </p><p>
        <asp:DropDownList ID="CountryDDL" runat="server"></asp:DropDownList>
                </p>

        <p>
            <asp:Label ID="Label8" runat="server" Text="Cellphone number: "></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="CellphoneTxt" runat="server"></asp:TextBox>
        </p>

         <p>
            <asp:Label ID="Label9" runat="server" Text="Home/Work number: "></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="PhoneTxt2" runat="server"></asp:TextBox>
        </p>
    </div>

    <div id="center_column" class="col-md-9 col-sm-8">


<div class="order_carrier_content box_background"><h1 class="page-heading">Shipping/Collection</h1>


<div class="delivery_options_address"><h3> Choose a shipping option for this address: My address test</h3>

    <div class="delivery_options">

        <div class="delivery_option item">

            <div>
                <table class="resume table table-bordered">
                <tr>
                    <td class="delivery_option_radio"> 
                <input id="delivery_option_31730_0" class="delivery_option_radio" type="radio" name="delivery_option[31730]" data-key="4," data-id_address="31730" value="4," checked="checked" />
                </td>
                <td class="delivery_option_logo"> <img src="/img/s/4.jpg" alt="Rebel Tech" />
                </td>
                <td class="delivery_option_information" style="width: 250px; float: left;"> <strong>TimeMastersSTS</strong> 
                <br /> Pick up in-store 
                <br /> 

            <span class="best_grade best_grade_price label label-success">The best price
            </span> 
            <br />
            </td>
            <td class="delivery_option_price">

            <div class="delivery_option_price"> Collection
            </div>
         </td>
         </tr>
        </table>
    </div>
</div>

<div class="delivery_option alternate_item">

<div>
<table class="resume table table-bordered">
<tr>
<td class="delivery_option_radio"> 
<input id="delivery_option_31730_1" class="delivery_option_radio" type="radio" name="delivery_option[31730]" data-key="15," data-id_address="31730" value="15," />
</td>
<td class="delivery_option_logo"> <img src="/img/s/15.jpg" alt="The Courier Guy (Insured up to R1000)" />
</td>
<td class="delivery_option_information" style="width: 250px; float: left;"> <strong>The Courier Guy (Insured up to R1000)</strong> 
<br /> Between 1 - 3 Working Days 
<br /> 

<span class="best_grade best_grade_speed label label-success">The fastest
</span> 
<br />
</td>
<td class="delivery_option_price">

<div class="delivery_option_price"> R 120 (VAT incl.)
</div>
</td>
</tr>
</table>
</div>
</div>
</div>


</div>



<div class="terms_wrapper"><h3 class="condition_title">Terms of service</h3>

<p class="checkbox"> 
<input type="checkbox" name="cgv" id="cgv" value="1" /> 
<label for="cgv">I agree to the terms of service and will adhere to them unconditionally.
</label> <a href="http://brokenlink" class="iframe" rel="nofollow">(Read the Terms of Service)</a></p>
</div>
</div>

<p class="cart_navigation submit"> 
<asp:Button ID="Button1" runat="server" Text="<- Back" /> &nbsp;&nbsp; <asp:Button ID="Button2" runat="server" Text="Next ->" /></p>

</div>



</asp:Content>

