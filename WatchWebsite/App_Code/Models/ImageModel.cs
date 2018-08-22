using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ImageModel
/// </summary>
public class ImageModel
{
    public string InsertImage(Image image)
    {
        try
        {
            WatchDatabaseV4Entities dbo = new WatchDatabaseV4Entities();
            dbo.Images.Add(image);
            dbo.SaveChanges();

            return image.Description + " was succesfully inserted";
        }
        catch (Exception e)
        {
            return "Error: " + e;
        }
    }

    public string UpdateImage(int id, Image image)
    {

        try
        {
            WatchDatabaseV4Entities dbo = new WatchDatabaseV4Entities();

            //fetch from db
            Image i = dbo.Images.Find(id);

            // keys
            i.Image_ID = image.Image_ID;

            // name..?
            // TODO fix name
            i.Description = image.Description;
            i.FilePath = image.FilePath;
            

            dbo.SaveChanges();
            return image.Description + " was succesfully updated";

        }
        catch (Exception e)
        {
            return "Error: " + e;
        }

    }

    public string DeleteImage(int id)
    {

        try
        {
            WatchDatabaseV4Entities dbo = new WatchDatabaseV4Entities();
            Image image = dbo.Images.Find(id);

            dbo.Images.Attach(image);
            dbo.Images.Remove(image);
            dbo.SaveChanges();

            return image.Description + " was succesfully deleted";



        }
        catch (Exception e)
        {
            return "Error: " + e;
        }

    }

    public bool UploadImage(String filepath)
    {


        return false;
    }
    
    public bool RemoveImageFile(String filepath)
    {

        return false;
    }
}