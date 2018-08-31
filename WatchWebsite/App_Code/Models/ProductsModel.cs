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
            WatchDBv2Entities db = new WatchDBv2Entities();
            db.Products.Add(product);
            db.SaveChanges();

            return product.Name + " was succesfully inserted";
        }
        catch (Exception e) {
            return "Error: " + e;
        }

    }

    public string UpdateProduct(int id, Product product) {

        try
        {
            WatchDBv2Entities db = new WatchDBv2Entities();

            //fetch from db
            Product p = db.Products.Find(id);

            p.Name = product.Name;
            p.Price = product.Price;
            p.TypeId = product.TypeId;
            p.Description = product.Description;
            p.Image = product.Image;

            db.SaveChanges();
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
            WatchDBv2Entities db = new WatchDBv2Entities();
            Product product = db.Products.Find(id);

            db.Products.Attach(product);
            db.Products.Remove(product);
            db.SaveChanges();

            return product.Name + " was succesfully deleted";



        }
        catch (Exception e)
        {
            return "Error: " + e;
        }

    }


    public Product GetProduct(int id) {

        try {
            using (WatchDBv2Entities db = new WatchDBv2Entities()) {
                Product product = db.Products.Find(id);
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
            using (WatchDBv2Entities db = new WatchDBv2Entities())
            {
                List<Product> products = (from x in db.Products select x).ToList();
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
            using (WatchDBv2Entities db = new WatchDBv2Entities())
            {
                List<Product> products = (from x in db.Products where x.TypeId == typeId select x).ToList();
                return products;

            }
        }
        catch (Exception)
        {
            return null;

        }



    }


}