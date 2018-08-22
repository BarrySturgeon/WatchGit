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

    public string UpdateProduct(int id, Product product)
    {

        try
        {
            WatchDatabaseV4Entities dbo = new WatchDatabaseV4Entities();

            //fetch from db
            Product p = dbo.Products.Find(id);

            // keys
            p.Product_ID = product.Product_ID;
            p.Branch_ID = product.Branch_ID;
            p.ProductType_ID = product.ProductType_ID;
            p.Image_ID = product.Image_ID;

            // name..?
            // TODO fix name
            p.Description = product.Description;

            // prices
            p.Subtotal = product.Subtotal;
            p.VAT = product.VAT;
            p.Total = product.Total;

            // quantity
            p.Quantity = product.Quantity;

            // availability fields
            p.Is_Available = product.Is_Available;
            p.Is_Visible = product.Is_Visible;

            // other
            p.Material = product.Material;
            p.Watch_Series = product.Watch_Series;
            p.Watch_Style = product.Watch_Style;
            p.Watch_Movement = product.Watch_Movement;
            p.Watch_DialType = product.Watch_DialType;
            p.Watch_ModelYear = product.Watch_ModelYear;
            p.Jewel_Size = product.Jewel_Size;



            dbo.SaveChanges();
            return product.Description + " was succesfully updated";

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