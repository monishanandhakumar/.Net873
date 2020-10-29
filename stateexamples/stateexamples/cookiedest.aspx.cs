using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace stateexamples
{
    public partial class cookiedest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

            }

            protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie ct = Request.Cookies["MytrialCookie"];
            Label1.Text = ct["c1"].ToString();
              Label2.Text = ct["c2"];
          //  Label2.Text = Response.Cookies["MytrialCookie"].Value;
           
        }
    }
}