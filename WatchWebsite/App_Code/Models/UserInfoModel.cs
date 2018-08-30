using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for UserInfoModel
/// </summary>
public class UserInfoModel
{
    public UserInformation GetUserInformation(string guId)
    {

        WatchDBv2Entities db = new WatchDBv2Entities();
        UserInformation info = (from x in db.UserInformations where x.GUID == guId select x).FirstOrDefault();
        return info;
    }

    public void InsertUserInformation(UserInformation info)
    {

        WatchDBv2Entities db = new WatchDBv2Entities();
        db.UserInformations.Add(info);
        db.SaveChanges();
    }
}