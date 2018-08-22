using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for OrderItemModel
/// </summary>
public class OrderModel
{
    public OrderModel()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public String InsertOrderItem(Order orderItem)
    {
        try
        {
            WatchDatabaseV4Entities dbo = new WatchDatabaseV4Entities();
            dbo.Orders.Add(orderItem);
            dbo.SaveChanges();

            return "Add Successful";
        }
        catch (Exception e)
        {
            return "Error: " + e;
        }
    }

    public String UpdateOrderItem(int id, Order orderItem)
    {
        try
        {
            WatchDatabaseV4Entities dbo = new WatchDatabaseV4Entities();

            Order oi = dbo.Orders.Find(id);

            //Not so sure about this part, we need to make sure about this.
            oi.Customer_ID = orderItem.Customer_ID;
            oi.Order_ID = orderItem.Order_ID;
            oi.Product_ID = orderItem.Product_ID;

            dbo.SaveChanges();

            return "Update Successful";
        }
        catch (Exception e)
        {
            return "Error: " + e;
        }
    }

    public String DeleteOrderItem(int id)
    {
        try
        {
            WatchDatabaseV4Entities dbo = new WatchDatabaseV4Entities();

            Order orderItem = dbo.Orders.Find(id);

            dbo.Orders.Attach(orderItem);
            dbo.Orders.Remove(orderItem);

            dbo.SaveChanges();

            return "Delete Successful";
        }
        catch (Exception e)
        {
            return "Error: " + e;
        }
    }
}