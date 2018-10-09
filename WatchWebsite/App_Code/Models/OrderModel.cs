using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for OrderModel
/// </summary>
public class OrderModel
{
    public OrderModel()
    {
        //
        // TODO: Add constructor logic here
        //
    }


    public string InsertModel(Order order)
    {
        try
        {
            WatchDBv2Entities dbo = new WatchDBv2Entities();
            dbo.Orders.Add(order);
            dbo.SaveChanges();

            return order.OrderId + " was succesfully inserted";
        }
        catch (Exception e)
        {
            return "Error: " + e;
        }
    }

    public string UpdateProduct(int id, Order order)
    {

        try
        {
            WatchDBv2Entities dbo = new WatchDBv2Entities();

            //fetch from db
            Order o = dbo.Orders.Find(id);

            o.UserID = order.UserID;
            o.PaymentID = order.PaymentID;
            o.OrderDate = order.OrderDate;
            o.ShipDate = order.ShipDate;
            o.ShipperID = order.ShipperID;
            o.Timestamp = order.Timestamp;
            o.TransactStatus = order.TransactStatus;
            o.ErrorLoc = order.ErrorLoc;
            o.ErrorMsg = order.ErrorMsg;
            o.IsFullfilled = order.IsFullfilled;
            o.IsDeleted = order.IsDeleted;
            o.IsPaid = order.IsPaid;
            o.PaymentDate = order.PaymentDate;

            dbo.SaveChanges();
            return order.OrderId + " was succesfully updated";

        }
        catch (Exception e)
        {
            return "Error: " + e;
        }

    }

    public string DeleteProduct(int id)
    {

        try
        {
            WatchDBv2Entities dbo = new WatchDBv2Entities();
            Order order = dbo.Orders.Find(id);

            dbo.Orders.Attach(order);
            dbo.Orders.Remove(order);
            dbo.SaveChanges();

            return order.OrderId + " was succesfully deleted";

        }
        catch (Exception e)
        {
            return "Error: " + e;
        }

    }

}