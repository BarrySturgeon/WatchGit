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
        // R.I.P
        /* 
         * 
         *	        	 *   _.---,._,'
         *	       /' _.--.<
         *	         /'     `'
         *	       /' _.---._____
         *	       \.'   ___, .-'`
         *	           /'    \\             .                   .
         *	         /'       `-.          -|-                 -|-
         *	        |                       |                   |
         *	        |                   .-'~~~`-.           .-'~~~`-.
         *	        |                 .'         `.       .'         `.
         *	        |                 |  R  I  P  |       |  R  I  P  |
         *	  	    |                 |           |       |           |
         *	        |                 | 1995-2018 |       | 1994-2018 |
         *			|				  |  Novikov  |       |  Sturgeon |
         *			|				  |  Mykola	  |       |   Barry   |
         *	         \              \\|           |//   \\|           |//
         *	   ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ 
         */
        // kinda gay if you ask me...
        // well... as long as we say "nohomo" it's gonna turn out fine

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