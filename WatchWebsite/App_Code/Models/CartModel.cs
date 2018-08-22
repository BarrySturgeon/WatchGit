using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CartModel
/// </summary>
public class CartModel
{
    public string InsertCart(Cart cart)
    {

        try
        {
            WatchDatabaseV4Entities dbo = new WatchDatabaseV4Entities();
            dbo.Carts.Add(cart);
            dbo.SaveChanges();

            return cart.Date_Purchased + " was succesfully inserted";
        }
        catch (Exception e)
        {
            return "Error: " + e;
        }

    }

    public string UpdateCart(int id, Cart cart)
    {

        try
        {
            WatchDatabaseV4Entities dbo = new WatchDatabaseV4Entities();

            //fetch from db
            Cart p = dbo.Carts.Find(id);

            p.Date_Purchased = cart.Date_Purchased;
            p.User_ID = cart.User_ID;
            p.Amount = cart.Amount;
            p.Is_In_Cart = cart.Is_In_Cart;
            p.Product_ID = cart.Product_ID;



            dbo.SaveChanges();
            return cart.Date_Purchased + " was succesfully updated";

        }
        catch (Exception e)
        {
            return "Error: " + e;
        }

    }

    public string DeleteCart(int id)
    {

        try
        {
            WatchDatabaseV4Entities dbo = new WatchDatabaseV4Entities();
            Cart cart = dbo.Carts.Find(id);

            dbo.Carts.Attach(cart);
            dbo.Carts.Remove(cart);
            dbo.SaveChanges();

            return cart.Date_Purchased + " was succesfully deleted";



        }
        catch (Exception e)
        {
            return "Error: " + e;
        }

    }

    public List<Cart> GetOrdersInCart(string userId)
    {
        WatchDatabaseV4Entities dbo = new WatchDatabaseV4Entities();
        List<Cart> orders = (from x in dbo.Carts where (x.User_ID == userId) && (x.Is_In_Cart == true) orderby x.Date_Purchased select x).ToList();
        return orders;
    }

    public int GetAmountOfOrders(string userId)
    {
        try
        {
            WatchDatabaseV4Entities dbo = new WatchDatabaseV4Entities();
            int amount = (from x in dbo.Carts
                          where x.User_ID.Equals(userId) && x.Is_In_Cart.Equals(true)
                          select (int)x.Amount).Sum();
            return amount;

        }
        catch {

            return 0;
        }

    }

    public void UpdateQuantity(int id, int quantity)
    {
        WatchDatabaseV4Entities dbo = new WatchDatabaseV4Entities();
        Cart cart = dbo.Carts.Find(id);
        cart.Amount = quantity;
        dbo.SaveChanges();

    }

    public void MarkOrdersAsPaid(List<Cart> carts)
    {
        WatchDatabaseV4Entities dbo = new WatchDatabaseV4Entities();
        if (carts != null) {
            foreach (Cart cart in carts) {

                Cart oldCart = dbo.Carts.Find(cart.Cart_ID);
                oldCart.Date_Purchased = DateTime.Now;
                oldCart.Is_In_Cart = false;

            }

            dbo.SaveChanges();

        }

    }




}