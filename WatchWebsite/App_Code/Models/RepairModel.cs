using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for RepairModel
/// </summary>
public class RepairModel
{
    public string InserRepair(Repair repair)
    {

        try
        {
            WatchDatabaseV4Entities dbo = new WatchDatabaseV4Entities();
            dbo.Repairs.Add(repair);
            dbo.SaveChanges();

            return repair.Customer_ID + repair.Status + " was succesfully inserted";
        }
        catch (Exception e)
        {
            return "Error: " + e;
        }

    }

    public string UpdateRepair(int id, Repair repair)
    {

        try
        {
            WatchDatabaseV4Entities dbo = new WatchDatabaseV4Entities();

            //fetch from db
            Repair r = dbo.Repairs.Find(id);

            // keys
            r.Repair_ID = repair.Repair_ID;
            r.Customer_ID = repair.Customer_ID;

            r.Status = repair.Status;

            // prices
            r.Subtotal = repair.Subtotal;
            r.VAT = repair.VAT;
            r.Total = repair.Total;

            r.DateStart = repair.DateStart;
            r.DateEnd = repair.DateEnd;
            r.DeliveryFlag = repair.DeliveryFlag;

            dbo.SaveChanges();
            return repair.Customer_ID  + repair.Status + " was succesfully updated";

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
            WatchDatabaseV4Entities dbo = new WatchDatabaseV4Entities();
            Product product = dbo.Products.Find(id);

            dbo.Products.Attach(product);
            dbo.Products.Remove(product);
            dbo.SaveChanges();

            return product.Description + " was succesfully deleted";



        }
        catch (Exception e)
        {
            return "Error: " + e;
        }

    }
}