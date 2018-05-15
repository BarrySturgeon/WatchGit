using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Account_Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        // API to create user

        UserStore<IdentityUser> userStore = new UserStore<IdentityUser>();

        userStore.Context.Database.Connection.ConnectionString = 
            System.Configuration.ConfigurationManager.ConnectionStrings["WatchDBEntitiesConnectionString"].ConnectionString;

        UserManager<IdentityUser> manager = new UserManager<IdentityUser>(userStore);


        // Actually creating the user in the database
        IdentityUser user = new IdentityUser();
        user.UserName = txtUsrName.Text;

        if(txtPassword.Text == txtConfirmPassword.Text)
        {
            try
            {
                IdentityResult result = manager.Create(user, txtPassword.Text);
                if(result.Succeeded)
                {
                    // Store in DB
                    var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;

                    // Set to log in by Cookie
                    var userIdentity = manager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);

                    // Redirect to home page
                    authenticationManager.SignIn(new AuthenticationProperties(), userIdentity);
                    Response.Redirect("~/about.aspx"); // no index page, will have to redirect to "about"
                }
                else
                {
                    litStatus.Text = result.Errors.FirstOrDefault();
                }
            }
            catch(Exception ex)
            {
                litStatus.Text = ex.Message;
            }
        }
        else
        {
            litStatus.Text = "Passwords do not match";
        }
    }
}