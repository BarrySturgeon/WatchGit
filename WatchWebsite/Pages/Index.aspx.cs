﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        FillPage();
    }

    private void FillPage()
    {
        try
        {
            ProductsModel productModel = new ProductsModel();
            List<Product> products = productModel.GetAllProducts();

            if (products != null)
            {
                foreach (Product product in products)
                {
                    Panel productPanel = new Panel();
                    ImageButton imageButton = new ImageButton();
                    Label lblName = new Label();
                    Label lblPrice = new Label();

                    imageButton.ImageUrl = "~/Images/Products/" + product.Image;
                    imageButton.CssClass = "productImage";
                    imageButton.PostBackUrl = "~/Pages/Product.aspx?id=" + product.Id;

                    lblName.Text = product.Name;
                    lblName.CssClass = "productName";

                    lblPrice.Text = "R " + product.Price;
                    lblPrice.CssClass = "productPrice";

                    productPanel.Controls.Add(imageButton);
                    productPanel.Controls.Add(new Literal { Text = "<br />" });
                    productPanel.Controls.Add(lblName);
                    productPanel.Controls.Add(new Literal { Text = "<br />" });
                    productPanel.Controls.Add(lblPrice);

                    pnlProducts.Controls.Add(productPanel);
                }
            }
            else
            {
                pnlProducts.Controls.Add(new Literal { Text = "No products found!" });
            }
        }
        catch(Exception e)
        {
            String temp = e.ToString();
            System.Console.WriteLine("Hello world " + temp);
            Response.Redirect("~/Pages/Errors/InternalServerErrorPage.aspx");
        }
    }

    private void InitializeSearch()
    {
        // TODO
        // probably not needed here
    }


    protected void SearchBtn_Click(object sender, EventArgs e)
    {
        // redirect to Search.aspx
        // but bring in some args 
        // String of what is being searched so that Search.aspx could process it
        Response.Redirect("~/Pages/Search.aspx");

    }
}