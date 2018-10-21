using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;

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
            System.Configuration.ConfigurationManager.ConnectionStrings["WatchDBv2ConnectionString"].ConnectionString;


        UserManager<IdentityUser> manager = new UserManager<IdentityUser>(userStore);

        SmtpClient client = new SmtpClient();
        client.DeliveryMethod = SmtpDeliveryMethod.Network;
        client.EnableSsl = true;
        client.Host = "smtp.gmail.com";
        client.Port = 587;

        // setup Smtp authentication
        System.Net.NetworkCredential credentials =
            new System.Net.NetworkCredential("webmastertimemastersts@gmail.com", "RyanBlue21");
        client.UseDefaultCredentials = false;
        client.Credentials = credentials;


        MailMessage msg = new MailMessage();
        msg.From = new MailAddress("webmastertimemastersts@gmail.com");
        msg.To.Add(new MailAddress(txtEmail.Text));

        msg.Subject = "Thanks for registering, " + txtFirstName.Text;
        msg.IsBodyHtml = true;
        msg.Body = string.Format("<html><head></head><body><h1>Thank you for registering with Timemasters:Swiss Timepiece Specialists</h1><p>If you have any questions of concerns feel free to email this address.</p><p>If you did not sign up, please notify this email and we will rectify the mistake. </p><p>Thanks! Regards from Timemaster:STS</p></body>");

        try
        {
            client.Send(msg);
        }
        catch (Exception ex)
        {
        }

        // Creating the user
        IdentityUser user = new IdentityUser();
        user.UserName = txtUsrName.Text;


        if(txtPassword.Text == txtConfirmPassword.Text)
        {
            try
            {
                IdentityResult result = manager.Create(user, txtPassword.Text);
                if(result.Succeeded)
                {

                    UserInformation info = new UserInformation {

                        Address = txtAddress.Text,
                        FirstName = txtFirstName.Text,
                        LastName = textLastName.Text,
                        GUID = user.Id
                    };

                    UserInfoModel model = new UserInfoModel();
                    model.InsertUserInformation(info);

                    // Store in DB
                    var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;

                    // Set to log in by Cookie
                    var userIdentity = manager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);

                    litStatus.Text = "Registration successful!";

                    // Redirect to home page
                    authenticationManager.SignIn(new AuthenticationProperties(), userIdentity);
                    Response.Redirect("~/Pages/Index.aspx"); 
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

    protected void txtConfirmPassword_TextChanged(object sender, EventArgs e)
    {
        if (txtPassword.Text.Length != txtConfirmPassword.Text.Length)
        {
            StatusLabel.Text = "<span style='color:red'>Passwords do not match</span>";

        }
        else if (txtPassword.Text.Length == txtConfirmPassword.Text.Length
            && (!txtConfirmPassword.Text.Equals("") || !txtPassword.Text.Equals("")))
        {
            StatusLabel.Text = "";
        }
    }
}