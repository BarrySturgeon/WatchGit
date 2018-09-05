using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Search : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Initialize page (if necessary)
        // Fill page (a MUST) !

        // brings me back some nightmares from FIT3037 Software Engineering...
        /*
        =================     ===============     ===============   ========  ========
        \\ . . . . . . .\\   //. . . . . . .\\   //. . . . . . .\\  \\. . .\\// . . //
        ||. . ._____. . .|| ||. . ._____. . .|| ||. . ._____. . .|| || . . .\/ . . .||
        || . .||   ||. . || || . .||   ||. . || || . .||   ||. . || ||. . . . . . . ||
        ||. . ||   || . .|| ||. . ||   || . .|| ||. . ||   || . .|| || . | . . . . .||
        || . .||   ||. _-|| ||-_ .||   ||. . || || . .||   ||. _-|| ||-_.|\ . . . . ||
        ||. . ||   ||-'  || ||  `-||   || . .|| ||. . ||   ||-'  || ||  `|\_ . .|. .||
        || . _||   ||    || ||    ||   ||_ . || || . _||   ||    || ||   |\ `-_/| . ||
        ||_-' ||  .|/    || ||    \|.  || `-_|| ||_-' ||  .|/    || ||   | \  / |-_.||
        ||    ||_-'      || ||      `-_||    || ||    ||_-'      || ||   | \  / |  `||
        ||    `'         || ||         `'    || ||    `'         || ||   | \  / |   ||
        ||            .===' `===.         .==='.`===.         .===' /==. |  \/  |   ||
        ||         .=='   \_|-_ `===. .==='   _|_   `===. .===' _-|/   `==  \/  |   ||
        ||      .=='    _-'    `-_  `='    _-'   `-_    `='  _-'   `-_  /|  \/  |   ||
        ||   .=='    _-'          `-__\._-'         `-_./__-'         `' |. /|  |   ||
        ||.=='    _-'                                                     `' |  /==.||
        =='    _-'                                                            \/   `==
        \   _-'                                                                `-_   /
        `''                                                                      ``'
                                            ______              
                                       .d$$$******$$$$c.        
                                    .d$P"            "$$c      
                                   $$$$$.           .$$$*$.    
                                 .$$ 4$L*$$.     .$$Pd$  '$b   
                                 $F   *$. "$$e.e$$" 4$F   ^$b  
                                d$     $$   z$$$e   $$     '$. 
                                $P     `$L$$P` `"$$d$"      $$ 
                                $$     e$$F       4$$b.     $$ 
                                $b  .$$" $$      .$$ "4$b.  $$ 
                                $$e$P"    $b     d$`    "$$c$F 
                                '$P$$$$$$$$$$$$$$$$$$$$$$$$$$  
                                 "$c.      4$.  $$       .$$   
                                  ^$$.      $$ d$"      d$P    
                                    "$$c.   `$b$F    .d$P"     
                                      `4$$$c.$$$..e$$P"        
                                          `^^^^^^^`

        DONT TOUCH MUH ART!

        * */
        TestLabel.Text = Page.ToString();
        // need to figure a way out how to extract the "message" and process it in this class
        // very similar to Assignment 2 from Software Engineering
        // pass a message from one class to another class
        // Index.aspx -> Message -> Search.aspx
        FillPage("string");
    }

    private void FillPage(String args)
    {
        try
        {
            ProductsModel productModel = new ProductsModel();
            List<Product> products = productModel.GetAllProducts(args);

            if (products != null)
            {
                foreach (Product product in products)
                {
                    Panel productPanel = new Panel();
                    ImageButton imageButton = new ImageButton();
                    Label lblName = new Label();
                    Label lblPrice = new Label();

                    imageButton.ImageUrl = "~/Images/Products/" + product.Image;
                    imageButton.CssClass = "productImage";
                    imageButton.PostBackUrl = "~/Pages/Product.aspx?id=" + product.Id;

                    lblName.Text = product.Name;
                    lblName.CssClass = "productName";

                    lblPrice.Text = "R " + product.Price;
                    lblPrice.CssClass = "productPrice";

                    productPanel.Controls.Add(imageButton);
                    productPanel.Controls.Add(new Literal { Text = "<br />" });
                    productPanel.Controls.Add(lblName);
                    productPanel.Controls.Add(new Literal { Text = "<br />" });
                    productPanel.Controls.Add(lblPrice);

                    pnlProducts.Controls.Add(productPanel);
                }
            }
            else
            {
                pnlProducts.Controls.Add(new Literal { Text = "No products found!" });
            }
        }
        catch (Exception e)
        {
            String temp = e.ToString();
            System.Console.WriteLine("Hello world " + temp);
            Response.Redirect("~/Pages/Errors/InternalServerErrorPage.aspx");
        }
    }

    protected void SearchBtn_Click(object sender, EventArgs e)
    {
        // 
        String payload = SearchBar.Text;



        // redirect to Search.aspx
        // but bring in some args 
        // String of what is being searched so that Search.aspx could process it
        Response.Redirect("~/Pages/Search.aspx?s=" + SearchBar.Text);

    }

    protected void SearchBar_TextChanged(object sender, EventArgs e)
    {
        // wut
    }
}
 