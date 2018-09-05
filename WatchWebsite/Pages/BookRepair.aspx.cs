using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_BookRepair : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lbResult.Text = string.Empty;
    }

    protected void BtnSub_Click(object sender, EventArgs e)
    {

        Button1.Visible = true;

        foreach (ListItem item in chBox.Items)
        {
            if (item.Selected) {

                lbResult.Text += item.Text + ": price for fixing ranges from R " + item.Value + "<br>";

            }

        }
      
        



    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Pages/Account/login.aspx");
    }
}