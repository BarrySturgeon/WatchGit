using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Account_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Page.PreviousPage != null && Page.PreviousPage.Request.Url == new Uri("~/Pages/Management/Management.aspx", UriKind.Absolute) )
        /* "~/Pages/Management/Management.aspx" */
        {
            throw new HttpException(403, "Forbidden");

            //Response.StatusCode = 403;
            //Response.End();

            // code not functioning properly
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        UserStore<IdentityUser> userStore = new UserStore<IdentityUser>();

        userStore.Context.Database.Connection.ConnectionString =
            System.Configuration.ConfigurationManager.ConnectionStrings["WatchDatabaseV4Entities"].ConnectionString;


        UserManager<IdentityUser> manager = new UserManager<IdentityUser>(userStore);

        var user = manager.Find(txtUsrName.Text, txtPassword.Text);

        if (user != null)
        {
            var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
            var userIdentity = manager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);

            authenticationManager.SignIn(new AuthenticationProperties
            {
                IsPersistent = false
            }, userIdentity);

            Response.Redirect("~/Pages/Index.aspx");
        }
        else
        {
            litStatus.Text = "Invalid username or password";
        }
    }
}