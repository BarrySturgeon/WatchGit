using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CustomerModel
/// </summary>
public class CustomerModel
{
    public CustomerModel()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public String InsertCustomer(Customer customer)
    {
        try
        {
            WatchDBEntities wdb = new WatchDBEntities();
            wdb.Customers.Add(customer);
            wdb.SaveChanges();

            return "Add Successful";
        }
        catch (Exception e)
        {
            return "Error: " + e;
        }
    }

    public String UpdateCustomer(int id, Customer customer)
    {
        try
        {
            ///

            return "Update Successful";
        }
        catch (Exception e)
        {
            return "Error: " + e;
        }
    }

    public String DeleteCustomer(int id)
    {
        try
        {
            WatchDBEntities wdb = new WatchDBEntities();

            Customer customer = wdb.Customers.Find(id);

            wdb.Customers.Attach(customer);
            wdb.Customers.Remove(customer);

            wdb.SaveChanges();

            return "Delete Successful";
        }
        catch (Exception e)
        {
            return "Error: " + e;
        }
    }
}