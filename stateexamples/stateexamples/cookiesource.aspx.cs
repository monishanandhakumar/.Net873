using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace stateexamples
{
    public partial class cookiesource : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie hc = new HttpCookie("MytrialCookie");
            hc["c1"] = TextBox1.Text;
            hc["c2"] = TextBox2.Text;
           // hc["c2"] = "admin";
            Response.Cookies.Add(hc);
            hc.Expires = DateTime.Now.AddMinutes(10);
            
            Response.Redirect("cookiedest.aspx");
        }
    }
}