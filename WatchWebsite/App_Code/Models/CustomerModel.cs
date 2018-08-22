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
            WatchDatabaseV4Entities dbo = new WatchDatabaseV4Entities();
            dbo.Customers.Add(customer);
            dbo.SaveChanges();

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
            WatchDatabaseV4Entities dbo = new WatchDatabaseV4Entities();
            Customer c = dbo.Customers.Find(id);
            c.FirstName = customer.FirstName;
            c.LastName = customer.LastName;  
            c.Address = customer.Address;
            c.BillAddress = customer.BillAddress;

            dbo.SaveChanges();

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
            WatchDatabaseV4Entities dbo = new WatchDatabaseV4Entities();

            Customer customer = dbo.Customers.Find(id);

            dbo.Customers.Attach(customer);
            dbo.Customers.Remove(customer);

            dbo.SaveChanges();

            return "Delete Successful";
        }
        catch (Exception e)
        {
            return "Error: " + e;
        }
    }
}