<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Checkout.aspx.cs" Inherits="Pages_Order" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <!-- you guessed it...
        YOINK -->

    <div id="center_column" class="col-md-9 col-sm-8">

<div id="carrier_area">


<form id="form" action="https://www.rebeltech.co.za/order" method="post" name="carrier_area">

<div class="order_carrier_content box_background"><h1 class="page-heading">Shipping/Collection</h1>

<div id="HOOK_BEFORECARRIER">
</div>

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
<td class="delivery_option_information" style="width: 250px; float: left;"> <strong>Rebel Tech</strong> 
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

<div class="hook_extracarrier" id="HOOK_EXTRACARRIER_31730">
</div>
</div>

<div id="extra_carrier" style="display: none;">
</div>

<div class="terms_wrapper"><h3 class="condition_title">Terms of service</h3>

<p class="checkbox"> 
<input type="checkbox" name="cgv" id="cgv" value="1" /> 
<label for="cgv">I agree to the terms of service and will adhere to them unconditionally.
</label> <a href="https://www.rebeltech.co.za/content/3-terms-and-conditions-of-use?content_only=1" class="iframe" rel="nofollow">(Read the Terms of Service)</a></p>
</div>
</div>

<p class="cart_navigation submit"> 
<input type="hidden" name="step" value="3" /> 
<input type="hidden" name="back" value="" /> <a href="https://www.rebeltech.co.za/order?step=1&amp;multi-shipping=" title="Previous" class="button"><i class="fa fa-chevron-left"></i>&nbsp;&nbsp; Previous</a> 

<span class="pull-right button yellow with-icon-nav right"> 
<input type="submit" name="processCarrier" value="Next" /> <i class="fa fa-chevron-right"></i> 
</span></p>
</form>
</div>
</div> <aside id="right_column" class="col-md-3 col-sm-4 hidden">



</asp:Content>

