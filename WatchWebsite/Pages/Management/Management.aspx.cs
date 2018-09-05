using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Management_Management : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var user = Context.User.Identity;

        // #best cybersecurity in  2k18 :D /s
        if(user.IsAuthenticated)
        {
            if(!(user.Name == "admin" || user.Name == "adminRyan"))
            {
                //Response.StatusCode = 401;
                //Response.End();
                throw new HttpException(403, "Forbidden");
            }
        }
        else
        {
            //Response.StatusCode = 401;
            //Response.End();
            throw new HttpException(403, "Forbidden");
        }
    }

    protected void GrdProducts_RowEditing(Object sender, GridViewEditEventArgs e)
    {
        GridViewRow row = grdProducts.Rows[e.NewEditIndex];
        int rowId = Convert.ToInt32(row.Cells[1].Text);
        Response.Redirect("~/Pages/Management/ManageProducts.aspx?id=" + rowId);


    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }
}