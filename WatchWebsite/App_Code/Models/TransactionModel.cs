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
            WatchDatabaseV4Entities dbo = new WatchDatabaseV4Entities();
            dbo.Transactions.Add(transaction);
            dbo.SaveChanges();

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
            WatchDatabaseV4Entities dbo = new WatchDatabaseV4Entities();
            Transaction t = dbo.Transactions.Find(id);
            t.Date = transaction.Date;
            t.Description = transaction.Description;
            t.Comment = transaction.Comment;
            t.Subtotal = transaction.Subtotal;
            t.VAT = transaction.VAT;
            t.Total = transaction.Total;

            dbo.SaveChanges();

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
            WatchDatabaseV4Entities dbo = new WatchDatabaseV4Entities();

            Transaction transaction = dbo.Transactions.Find(id);

            dbo.Transactions.Attach(transaction);
            dbo.Transactions.Remove(transaction);

            dbo.SaveChanges();

            return "Delete Successful";
        }
        catch (Exception e)
        {
            return "Error: " + e;
        }
    }
}