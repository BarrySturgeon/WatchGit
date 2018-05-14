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

    public String UpdateTransaciton(int id, Transaction transaction)
    {
        try
        {
            //

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