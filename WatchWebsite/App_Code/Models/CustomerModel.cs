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
            WatchDBEntities wdb = new WatchDBEntities();
            Customer c = wdb.Customers.Find(id);
            c.First_Name = customer.First_Name; // to store Name I will use First Name (First Name + Last Name = Name, normalized attribute).
            c.Last_Name = customer.Last_Name;  // to store password I will use Last Name (since we don't have pwd field)
            c.Address = customer.Address;
            c.Phone_Number = customer.Phone_Number;
            c.Next_Repair_Date = customer.Next_Repair_Date;

            wdb.SaveChanges();

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