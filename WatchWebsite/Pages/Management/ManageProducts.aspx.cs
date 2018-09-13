using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;




/*
 * TODO fix this!
 * It's not working since I messed with database
 * 
 * */
public partial class Pages_Management_ManageProducts : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) {
            GetImages();


            if (!String.IsNullOrWhiteSpace(Request.QueryString["id"])) {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                FillPage(id);
      
            }
        }

    }


    protected void BtnSubmit_Click(object sender, EventArgs e)
    {
        ProductsModel productsModel = new ProductsModel();
        Product product = CreateProduct();

        if (!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
        {

            int id = Convert.ToInt32(Request.QueryString["id"]);
            lblResult.Text = productsModel.UpdateProduct(id, product);

        }
        else {
            lblResult.Text = productsModel.InsertProduct(product);

        }


                
    }

    private void FillPage(int id)
    {
        ProductsModel productsModel = new ProductsModel();
        Product product = productsModel.GetProduct(id);

        txtDescription.Text = product.Description;
        txtName.Text = product.Name;
        txtPrice.Text = product.Price.ToString();

        ddlImage.SelectedValue = product.Image;
        ddlType.SelectedValue = product.TypeId.ToString();  

    }

    private void GetImages()
    {

        try
        {
            string[] images = Directory.GetFiles(Server.MapPath("~/Images/Products/"));

            ArrayList imageList = new ArrayList();

            foreach (string image in images)
            {
                string imageName = image.Substring(image.LastIndexOf(@"\", StringComparison.Ordinal) + 1);
                imageList.Add(imageName);
            }


            ddlImage.DataSource = imageList;
            ddlImage.AppendDataBoundItems = true;
            ddlImage.DataBind();

        }
        catch (Exception e)
        {

            lblResult.Text = e.ToString();
        }


    }

    private Product CreateProduct() {

        Product product = new Product
        {
            Name = txtName.Text,
            Price = Convert.ToInt32(txtPrice.Text),
            TypeId = Convert.ToInt32(ddlType.SelectedValue),
            Description = txtDescription.Text,
            Image = ddlImage.SelectedValue,
            isVisible = IsVisibleCheckBox.Checked,
            isAvailable = IsAvailCheckBox.Checked
        };

        return product;
        

    }


}