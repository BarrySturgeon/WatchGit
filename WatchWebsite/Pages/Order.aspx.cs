using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


// YOINKED CODE
public partial class Pages_Order : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void FunkButton_Click(object sender, EventArgs e)
    {
        try
        {
            if (!Page.IsValid) return;

            // Create the order in your DB and get the ID
            string amount = "100.00";
            string orderId = null; // placeholder until fixed
            // TODO 
            // fix the followin:
            //string orderId = new CreateOrder(null);
            string name = "Time Masters Swiss Time Specialists, Order #" + orderId;
            string description = "Order description [desc]";

            string site = "";
            string merchant_id = "";
            string merchant_key = "";

            // Check if we are using the test or live system
            string paymentMode = System.Configuration.ConfigurationManager.AppSettings["PaymentMode"];

            if (paymentMode == "test")
            {
                site = "https://sandbox.payfast.co.za/eng/process?";
                merchant_id = "10000100";
                merchant_key = "46f0cd694581a";
            }
            else if (paymentMode == "live")
            {
                site = "https://www.payfast.co.za/eng/process?";
                merchant_id = System.Configuration.ConfigurationManager.AppSettings["PF_MerchantID"];
                merchant_key = System.Configuration.ConfigurationManager.AppSettings["PF_MerchantKey"];
            }
            else
            {
                throw new InvalidOperationException("Cannot process payment if PaymentMode (in web.config) value is unknown.");
            }

            // Build the query string for payment site

            StringBuilder str = new StringBuilder();
            str.Append("merchant_id=" + HttpUtility.UrlEncode(merchant_id));
            str.Append("&merchant_key=" + HttpUtility.UrlEncode(merchant_key));
            str.Append("&return_url=" + HttpUtility.UrlEncode(System.Configuration.ConfigurationManager.AppSettings["PF_ReturnURL"]));
            str.Append("&cancel_url=" + HttpUtility.UrlEncode(System.Configuration.ConfigurationManager.AppSettings["PF_CancelURL"]));
            str.Append("&notify_url=" + HttpUtility.UrlEncode(System.Configuration.ConfigurationManager.AppSettings["PF_NotifyURL"]));

            str.Append("&m_payment_id=" + HttpUtility.UrlEncode(orderId));
            str.Append("&amount=" + HttpUtility.UrlEncode(amount));
            str.Append("&item_name=" + HttpUtility.UrlEncode(name));
            str.Append("&item_description=" + HttpUtility.UrlEncode(description));

            // Redirect to PayFast
            Response.Redirect(site + str.ToString());
        }
        catch (Exception ex)
        {
            // Handle your errors here (log them and tell the user that there was an error)
            // NO! 
            // Nico does not handle exceptions
            // Nico is a fucking retard
            // Don't be like Nico
        }
    }

}