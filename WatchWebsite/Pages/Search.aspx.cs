﻿using System;
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
        FillPage(e.ToString());
    }

    private void FillPage(String args)
    {
        // TODO 
        // handle the search 
    }
}
 