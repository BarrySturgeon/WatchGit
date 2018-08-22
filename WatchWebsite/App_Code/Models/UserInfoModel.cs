using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for UserInfoModel
/// </summary>
public class UserInfoModel
{
    public UserInformation GetUserInformation(string guId) {

        WatchDatabaseV4Entities db = new WatchDatabaseV4Entities();
        UserInformation info = (from x in dbo.UserInformations where x.GUID == guId select x).FirstOrDefault();
        return info;
    }

    public void InsertUserInformation(UserInformation info) {

        WatchDatabaseV4Entities db = new WatchDatabaseV4Entities();
        dbo.UserInformations.Add(info);
        dbo.SaveChanges();
    }
}