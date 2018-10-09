using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Product : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        FillPage();
    }

    private void FillPage()
    {
        try
        {
            if (!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                ProductsModel productsModel = new ProductsModel();
                Product product = productsModel.GetProduct(id);

                lblPrice.Text = "Price per unit: <br/>R " + product.Price;
                lblTitle.Text = product.Name;
                lblDescription.Text = product.Description;
                lblItemNo.Text = id.ToString();
                imgProduct.ImageUrl = "~/Images/Products/" + product.Image;

                int[] amount = Enumerable.Range(1, 20).ToArray();
                ddlAmount.DataSource = amount;
                ddlAmount.AppendDataBoundItems = true;
                ddlAmount.DataBind();

            }
            else
            {
                // error unhandled
            }
        }
        catch(Exception e)
        {
            String temp = e.ToString();
            System.Console.WriteLine("Hello world " + temp);
            Response.Redirect("~/Pages/Errors/InternalServerErrorPage.aspx");
        }

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        try
        {
            if (!string.IsNullOrWhiteSpace(Request.QueryString["id"]))
            {
                string clientID = Context.User.Identity.GetUserId();


                if (clientID != null)
                {

                    int id = Convert.ToInt32(Request.QueryString["id"]);
                    int amount = Convert.ToInt32(ddlAmount.SelectedValue);

                    Cart cart = new Cart
                    {
                        Amount = amount,
                        ClientID = clientID,
                        DatePurchased = DateTime.Now,
                        IsInCart = true,
                        ProductID = id
                    };

                    CartModel model = new CartModel();
                    lblResult.Text = model.InsertCart(cart);

                }
                else
                {
                    lblResult.Text = "Please log in to order items";

                }
            }
        }
        catch(Exception ex)
        {
            String temp = ex.ToString();
            System.Console.WriteLine("Hello world " + temp);
            Response.Redirect("~/Pages/Errors/InternalServerErrorPage.aspx");
        }
    }
}