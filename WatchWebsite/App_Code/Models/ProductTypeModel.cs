using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ProductTypeTypeModel
/// </summary>
public class ProductTypeTypeModel
{

    public string InsertProductType(ProductType productType)
    {

        try
        {
            WatchDBv2Entities dbo = new WatchDBv2Entities();
            dbo.ProductTypes.Add(productType);
            dbo.SaveChanges();

            return productType.Name + " was succesfully inserted";
        }
        catch (Exception e)
        {
            return "Error: " + e;
        }

    }

    public string UpdateProductType(int id, ProductType productType)
    {

        try
        {
            WatchDBv2Entities dbo = new WatchDBv2Entities();

            //fetch from db
            ProductType p = dbo.ProductTypes.Find(id);

            p.Name = productType.Name;
            

            dbo.SaveChanges();
            return productType.Name + " was succesfully updated";

        }
        catch (Exception e)
        {
            return "Error: " + e;
        }

    }

    public string DeleteProductType(int id)
    {

        try
        {
            WatchDBv2Entities dbo = new WatchDBv2Entities();
            ProductType productType = dbo.ProductTypes.Find(id);

            dbo.ProductTypes.Attach(productType);
            dbo.ProductTypes.Remove(productType);
            dbo.SaveChanges();

            return productType.Name + " was succesfully deleted";



        }
        catch (Exception e)
        {
            return "Error: " + e;
        }

    }



}