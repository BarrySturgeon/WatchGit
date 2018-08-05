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

    protected void btnSub_Click(object sender, EventArgs e)
    {

        foreach (ListItem item in chBox.Items)
        {
            if (item.Selected) {

                lbResult.Text += item.Text + ": price for fixing ranges from R " + item.Value + "<br>";

            }

        }



    }
}