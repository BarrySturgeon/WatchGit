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
            WatchDBv2ConnectionStrings dbo = new WatchDBv2ConnectionStrings();
            dbo.Products.Add(product);
            dbo.SaveChanges();

            return product.Name + " was succesfully inserted";
        }
        catch (Exception e) {
            return "Error: " + e;
        }

    }

    public string UpdateProduct(int id, Product product) {

        try
        {
            WatchDBv2ConnectionStrings dbo = new WatchDBv2ConnectionStrings();

            //fetch from db
            Product p = dbo.Products.Find(id);

            p.Name = product.Name;
            p.Price = product.Price;
            p.TypeId = product.TypeId;
            p.Description = product.Description;
            p.Image = product.Image;

            dbo.SaveChanges();
            return product.Name + " was succesfully updated";

        }
        catch (Exception e)
        {
            return "Error: " + e;
        }

    }

    public string DeleteProduct(int id) {

        try
        {
            WatchDBv2ConnectionStrings dbo = new WatchDBv2ConnectionStrings();
            Product product = dbo.Products.Find(id);

            dbo.Products.Attach(product);
            dbo.Products.Remove(product);
            dbo.SaveChanges();

            return product.Name + " was succesfully deleted";



        }
        catch (Exception e)
        {
            return "Error: " + e;
        }

    }


    public Product GetProduct(int id) {

        try {
            using (WatchDBv2ConnectionStrings dbo = new WatchDBv2ConnectionStrings()) {
                Product product = dbo.Products.Find(id);
                return product;
            }

        }
        catch (Exception) {

            return null;

        }


    }


    public List<Product> GetAllProducts() {
        try
        {
            using (WatchDBv2ConnectionStrings dbo = new WatchDBv2ConnectionStrings())
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
            using (WatchDBv2ConnectionStrings dbo = new WatchDBv2ConnectionStrings())
            {
                List<Product> products = (from x in dbo.Products where x.TypeId == typeId select x).ToList();
                return products;

            }
        }
        catch (Exception)
        {
            return null;

        }



    }


}