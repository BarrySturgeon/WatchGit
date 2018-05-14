using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for TransactionModel
/// </summary>
public class TransactionModel
{
    public TransactionModel()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public String InsertTransaction(Transaction transaction)
    {
        try
        {
            WatchDBEntities wdb = new WatchDBEntities();
            wdb.Transactions.Add(transaction);
            wdb.SaveChanges();

            return "Add Successful";
        }
        catch (Exception e)
        {
            return "Error: " + e;
        }
    }

    public String UpdateBattery(int id, Battery battery)
    {
        try
        {
            WatchDBEntities wdb = new WatchDBEntities();

            Battery b = wdb.Batteries.Find(id);

            b.Battery1 = battery.Battery1;
            b.Branch = battery.Branch;

            wdb.SaveChanges();

            return "Update Successful";
        }
        catch (Exception e)
        {
            return "Error: " + e;
        }
    }

    public String DeleteTransaction(int id)
    {
        try
        {
            WatchDBEntities wdb = new WatchDBEntities();

            Transaction transaction = wdb.Transactions.Find(id);

            wdb.Transactions.Attach(transaction);
            wdb.Transactions.Remove(transaction);

            wdb.SaveChanges();

            return "Delete Successful";
        }
        catch (Exception e)
        {
            return "Error: " + e;
        }
    }
}