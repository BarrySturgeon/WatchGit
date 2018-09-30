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
        if (FileUpload1.HasFile)
        {
            FileUpload1.SaveAs(Server.MapPath("~/Images/Products/" + FileUpload1.FileName));
            lblUploadMessage.Text = "Image Uploaded";
            lblUploadMessage.ForeColor = System.Drawing.Color.Green;
        }
        else {
            lblUploadMessage.Text = "Please Select a file to upload";
            lblUploadMessage.ForeColor = System.Drawing.Color.Red;
        }
    }
}