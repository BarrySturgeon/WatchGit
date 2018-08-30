using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ProductsModel
/// </summary>
public class ProductsModel
{

    public string InsertProduct(Product product) {

        try
        {
            WatchDatabaseV4Entities dbo = new WatchDatabaseV4Entities();
            dbo.Products.Add(product);
            dbo.SaveChanges();

            return product.Description + " was succesfully inserted";
        }
        catch (Exception e) {
            return "Error: " + e;
        }

    }

    public string UpdateProduct(int id, Product product) {

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

    public string DeleteProduct(int id) {

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


    public Product GetProduct(int id) {

        try {
            using (WatchDatabaseV4Entities dbo = new WatchDatabaseV4Entities()) {
                Product product = dbo.Products.Find(id);
                return product;
            }

        }
        catch (Exception) {

            return null;

        }


    }


    // is the product available
    public bool IsAvailable(int id)
    {
        try
        {
            using (WatchDatabaseV4Entities dbo = new WatchDatabaseV4Entities())
            {
                Product product = dbo.Products.Find(id);
                return product.Is_Available;
            }

        }
        catch (Exception)
        {

            return false;

        }

    }

    // is the product visible (Visibility functionality for the website)
    public bool IsVisible(int id)
    {
        try
        {
            using (WatchDatabaseV4Entities dbo = new WatchDatabaseV4Entities())
            {
                Product product = dbo.Products.Find(id);
                return product.Is_Visible;
            }

        }
        catch (Exception)
        {

            return false;

        }
    }



    public List<Product> GetAllProducts() {
        try
        {
            using (WatchDatabaseV4Entities dbo = new WatchDatabaseV4Entities())
            {
                List<Product> products = (from x in dbo.Products select x).ToList();
                return products;

            }
        }
        catch (Exception) {
            return null;

        }


    }



    public List<Product> GetProductsByType(int typeId) {

        try
        {
            using (WatchDatabaseV4Entities dbo = new WatchDatabaseV4Entities())
            {
                List<Product> products = (from x in dbo.Products where x.ProductType_ID == typeId select x).ToList();
                return products;

            }
        }
        catch (Exception)
        {
            return null;

        }



    }


}