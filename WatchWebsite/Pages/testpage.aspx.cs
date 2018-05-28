using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_testpage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    // 404 error
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("nonexistentpage.aspx");
    }

    // unauthorized 
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Pages/Errors/UnauthorizedErrorPage.aspx");
    }

    // internal server error
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Pages/Errors/InternalServerErrorPage.aspx");
    }


    // free style error. play around
    protected void Button4_Click(object sender, EventArgs e)
    {

    }
}