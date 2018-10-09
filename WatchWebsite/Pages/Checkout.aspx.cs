using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/*
 * this class should set up everything before redirecting payment through gateway
 * in our flowchart this class represents --
 * 
 * 1. Insert an order into your database and get the orderid. This step is optional,
 * but will help you keep track of your orders and abandoned carts (people  who were trying ot order, but didn’t go through with the process).
 * 
 * this page is also where the user confirms and checks whether all the payment details are correct

 * */
public partial class Pages_Order : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if(false /* user is not logged in */)
        {
            // redirect to log in, 
            // then from there redirect back
        }

        // populate "Order" table with user input
        // this ("Checkout.aspx") page might possibly have to be merged with "Order.aspx" 


        // wait for user confirmation via button

        // then, goto payment gateway
        // afterwards magic happens
    }


    /*
     * readme.txt * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
     *  Notes
     *
     *   The flow works like this:
     *
     *   1. Insert an order into your database and get the orderid. This step is optional, but will help you keep track of your orders and abandoned carts (people  who were trying ot order, but didn’t go through with the process).
     *   2. Redirect to PayFast.
     *   3. When PayFast is done it will redirect to your site (return_url or cancel_url).
     *   4. You get a notification (ITN) with payment results.
     *   5. Validate that the notification is valid (security checks and validation checks)
     *   6. If notification is valid and status is COMPLETE, update the order you created in #1 (set some field like Paid to true). If you did not insert the order in 1, then you could just do the insert here (again, optional).
     *
     *   return.aspx:
     *
     *   This page is specified by the return_url field in the original form post to PayFast.
     *   Just thank the user and tell them you are processing their order (should already be done or take a few more seconds with ITN).
     *
     *   cancel.aspx:
     *
     *   This page is specified by the cancel_url field in the original form post to PayFast.
     *   Just thank the user and tell them that they cancelled the order (encourage them to email you if they have problems paying :)
     *
     *   notify.aspx:
     *
     *   This page is specified by the notify_url field in the original form post to PayFast.
     * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
     **/

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Pages/Order.aspx");
    }
}
