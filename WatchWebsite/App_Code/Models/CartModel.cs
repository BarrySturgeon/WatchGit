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
            WatchDBv2Entities dbo = new WatchDBv2Entities();
            dbo.Carts.Add(cart);
            dbo.SaveChanges();

            return cart.DatePurchased + " was succesfully inserted";
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
            WatchDBv2Entities dbo = new WatchDBv2Entities();

            //fetch from db
            Cart p = dbo.Carts.Find(id);

            p.DatePurchased = cart.DatePurchased;
            p.ClientID = cart.ClientID;
            p.Amount = cart.Amount;
            p.IsInCart = cart.IsInCart;
            p.ProductID = cart.ProductID;



            dbo.SaveChanges();
            return cart.DatePurchased + " was succesfully updated";

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
            WatchDBv2Entities dbo = new WatchDBv2Entities();
            Cart cart = dbo.Carts.Find(id);

            dbo.Carts.Attach(cart);
            dbo.Carts.Remove(cart);
            dbo.SaveChanges();

            return cart.DatePurchased + " was succesfully deleted";



        }
        catch (Exception e)
        {
            return "Error: " + e;
        }

    }

    public List<Cart> GetOrdersInCart(string userId)
    {
        WatchDBv2Entities dbo = new WatchDBv2Entities();
        List<Cart> orders = (from x in dbo.Carts where x.ClientID == userId && x.IsInCart orderby x.DatePurchased select x).ToList();
        return orders;
    }

    public int GetAmountOfOrders(string userId)
    {
        try
        {
            WatchDBv2Entities dbo = new WatchDBv2Entities();
            int amount = (from x in dbo.Carts
                          where x.ClientID == userId && x.IsInCart
                          select x.Amount).Sum();
            return amount;

        }
        catch {

            return 0;
        }

    }

    public void UpdateQuantity(int id, int quantity)
    {
        WatchDBv2Entities dbo = new WatchDBv2Entities();
        Cart cart = dbo.Carts.Find(id);
        cart.Amount = quantity;
        dbo.SaveChanges();

    }

    public void MarkOrdersAsPaid(List<Cart> carts)
    {
        WatchDBv2Entities dbo = new WatchDBv2Entities();
        if (carts != null) {
            foreach (Cart cart in carts) {

                Cart oldCart = dbo.Carts.Find(cart.ID);
                oldCart.DatePurchased = DateTime.Now;
                oldCart.IsInCart = false;

            }

            dbo.SaveChanges();

        }

    }




}