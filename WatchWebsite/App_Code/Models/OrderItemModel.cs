using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for OrderItemModel
/// </summary>
public class OrderItemModel
{
    public OrderItemModel()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public String InsertOrderItem(OrderItem orderItem)
    {
        try
        {
            WatchDBEntities wdb = new WatchDBEntities();
            wdb.OrderItems.Add(orderItem);
            wdb.SaveChanges();

            return "Add Successful";
        }
        catch (Exception e)
        {
            return "Error: " + e;
        }
    }

    public String UpdateOrderItem(int id, OrderItem orderItem)
    {
        try
        {
            WatchDBEntities wdb = new WatchDBEntities();

            OrderItem oi = wdb.OrderItems.Find(id);

            //Not so sure about this part, we need to make sure about this.
            oi.Customer_ID = orderItem.Customer_ID;
            oi.Order_ID = orderItem.Order_ID;
            oi.Item_ID = orderItem.Item_ID;

            wdb.SaveChanges();

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
            WatchDBEntities wdb = new WatchDBEntities();

            OrderItem orderItem = wdb.OrderItems.Find(id);

            wdb.OrderItems.Attach(orderItem);
            wdb.OrderItems.Remove(orderItem);

            wdb.SaveChanges();

            return "Delete Successful";
        }
        catch (Exception e)
        {
            return "Error: " + e;
        }
    }
}