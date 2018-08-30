using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Pages_ShoppingCart : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string userId = User.Identity.GetUserId();
        GetPurchasesInCart(userId);
    }

    private void GetPurchasesInCart(string userId)
    {
        CartModel model = new CartModel();
        double subTotal = 0;

        List<Cart> purchaseList = model.GetOrdersInCart(userId);
        CreateShopTable(purchaseList, out subTotal);

        double vat = subTotal * 0.15;
        double totalAmount = subTotal + vat + 50;

        litTotal.Text = "R " + subTotal;
        litVat.Text = "R " + vat;
        litTotalAmount.Text = "R " + totalAmount;
    }

    private void CreateShopTable(IEnumerable<Cart> carts, out double subTotal)
    {
        subTotal = new double();
        ProductsModel model = new ProductsModel();


        foreach (Cart cart in carts)
        {
            Product product = model.GetProduct((int)cart.Product_ID);

            //Create imagne buton

            ImageButton btnImage = new ImageButton
            {
                ImageUrl = string.Format("~/Images/Products/{0}", product.Image),
                PostBackUrl = string.Format("~/Pages/Product.aspx?id={0}", product.Product_ID),
            };

            //Create delete link
            LinkButton lnkDelete = new LinkButton
            {
                PostBackUrl = string.Format("~/Pages/ShoppingCart.aspx?productId={0}", cart.Product_ID),
                Text = "Delete Item",
                ID = "del" + cart.Product_ID;
            };

            //Add onclick event
            lnkDelete.Click += Delete_Item;

            //Create quantity dropdown list
            int[] amount = Enumerable.Range(1, 20).ToArray();
            DropDownList ddlAmount = new DropDownList
            {
                DataSource = amount,
                AppendDataBoundItems = true,
                AutoPostBack = true,
                ID = cart.ID.ToString()
            };

            ddlAmount.DataBind();
            ddlAmount.SelectedValue = cart.Amount.ToString();
            ddlAmount.SelectedIndexChanged += ddlAmount_SelectedIndexChanged;

            //Create html tables
            Table table = new Table { CssClass = "cartTable" };
            TableRow a = new TableRow();
            TableRow b = new TableRow();

            //create 6 cells for a
            TableCell a1 = new TableCell { RowSpan = 2, Width = 50 };
            TableCell a2 = new TableCell { Text = string.Format("<h4>{0}</h4><br/>{1}<br/>In Stock", product.Name, "Item No: " + product.Id), HorizontalAlign = HorizontalAlign.Left, Width = 350 };
            TableCell a3 = new TableCell { Text = "Unit Price<hr/>" };
            TableCell a4 = new TableCell { Text = "Quantity<hr/>" };
            TableCell a5 = new TableCell { Text = "Item Total<hr/>" };
            TableCell a6 = new TableCell { };

            //create 6 cells for b
            TableCell b1 = new TableCell { };
            TableCell b2 = new TableCell { Text = "R " + product.Price };
            TableCell b3 = new TableCell { };
            TableCell b4 = new TableCell { Text = "R " + Math.Round((cart.Amount * product.Price).Value, 2) }; //This line had to be ammended as it was throwing a error: cannot convert from double? to double.
            TableCell b5 = new TableCell { };
            TableCell b6 = new TableCell { };


            //set speical controls
            a1.Controls.Add(btnImage);
            a6.Controls.Add(lnkDelete);
            b3.Controls.Add(ddlAmount);

            //add cells to rows
            a.Cells.Add(a1);
            a.Cells.Add(a2);
            a.Cells.Add(a3);
            a.Cells.Add(a4);
            a.Cells.Add(a5);
            a.Cells.Add(a6);

            b.Cells.Add(b1);
            b.Cells.Add(b2);
            b.Cells.Add(b3);
            b.Cells.Add(b4);
            b.Cells.Add(b5);
            b.Cells.Add(b6);

            //Add rows to table
            table.Rows.Add(a);
            table.Rows.Add(b);

            //add table to pnlShoppingCart
            pnlShoppingCart.Controls.Add(table);

            //Add total amount item in cart to subtotal
            subTotal += (cart.Amount * product.Price).Value;    //This line also had to be ammened like on line 95.
        }


        //Add curent users shopping cart to user specific session
        Session[User.Identity.GetUserId()] = carts;
    }

    private void Delete_Item(object sender, EventArgs e)
    {
        LinkButton selectedLink = (LinkButton)sender;
        string link = selectedLink.ID.Replace("del", "");
        int cartId = Convert.ToInt32(link);

        CartModel model = new CartModel();
        model.DeleteCart(cartId);

        Response.Redirect("~/Pages/ShoppingCart.aspx");

    }


    private void ddlAmount_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropDownList selectedList = (DropDownList)sender;
        int quantity = Convert.ToInt32(selectedList.SelectedValue);
        int cartId = Convert.ToInt32(selectedList.ID);

        CartModel model = new CartModel();
        model.UpdateQuantity(cartId, quantity);

        Response.Redirect("~/Pages/ShoppingCart.aspx");

    }
}