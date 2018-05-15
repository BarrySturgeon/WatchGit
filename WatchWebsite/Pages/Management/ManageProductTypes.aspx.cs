using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Management_ManageProductTypes : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        ProductTypeTypeModel model = new ProductTypeTypeModel();
        ProductType pt = createProductType();
        lblResult.Text = model.InsertProductType(pt);
    }


    private ProductType createProductType()
    {
        ProductType p = new ProductType();
        p.Name = txtName.Text;
        return p;
    }
}