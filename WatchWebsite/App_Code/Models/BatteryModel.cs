using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BatteriesModel
/// </summary>
public class BatteryModel
{
    public BatteryModel()
    {
        // TODO
        // not auto generated anymore
    }

    public String InsertBattery(Battery battery)
    {
        try
        {
            WatchDBEntities wdb = new WatchDBEntities();
            wdb.Batteries.Add(battery);
            wdb.SaveChanges();

            return "Add Successful";
        }
        catch(Exception e)
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

    public String DeleteBattery(int id)
    {
        try
        {
            WatchDBEntities wdb = new WatchDBEntities();

            Battery battery = wdb.Batteries.Find(id);

            wdb.Batteries.Attach(battery);
            wdb.Batteries.Remove(battery);

            wdb.SaveChanges();

            return "Delete Successful";
        }
        catch (Exception e)
        {
            return "Error: " + e;
        }
    }
}