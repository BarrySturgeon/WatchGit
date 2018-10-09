using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


// here we do security checks
// point 4. in flowchart
public partial class Pages_Confirm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        DoSecurityCheck();
    }

    // TODO 
    // security check
    // whatever it is

    private void DoSecurityCheck()
    {




        // redirect to success page
        Response.Redirect("~/Pages/Success.aspx");
    }
}