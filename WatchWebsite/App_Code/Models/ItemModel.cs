using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ItemModel
/// </summary>
public class ItemModel
{
    public ItemModel()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public String InsertItem(Item item)
    {
        try
        {
            WatchDBEntities wdb = new WatchDBEntities();
            wdb.Items.Add(item);
            wdb.SaveChanges();

            return "Add Successful";
        }
        catch (Exception e)
        {
            return "Error: " + e;
        }
    }

    public String UpdateItem(int id, Item item)
    {
        try
        {
            WatchDBEntities wdb = new WatchDBEntities();

            Item i = wdb.Items.Find(id);

            i.Price = item.Price;
            i.Make = item.Make;
            i.Series = item.Series;
            i.Model_Year = item.Model_Year;
            i.Style = item.Style;
            i.Movement = item.Movement;
            i.Case_Material = item.Case_Material;
            i.Dial_Type = item.Dial_Type;
            i.Water_Resistance = item.Water_Resistance;
            i.Bracelet_Material = item.Bracelet_Material;
            i.Functions = item.Functions;
            i.Image = item.Image;

            wdb.SaveChanges();

            return "Update Successful";
        }
        catch (Exception e)
        {
            return "Error: " + e;
        }
    }

    public String DeleteItem(int id)
    {
        try
        {
            WatchDBEntities wdb = new WatchDBEntities();

            Item item = wdb.Items.Find(id);

            wdb.Items.Attach(item);
            wdb.Items.Remove(item);

            wdb.SaveChanges();

            return "Delete Successful";
        }
        catch (Exception e)
        {
            return "Error: " + e;
        }
    }
}