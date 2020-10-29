using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace stateexamples
{
    public partial class Testing : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            if (Page.IsPostBack)
            {
                //Create new cookie
                HttpCookie newCookie = new HttpCookie("UserName");

                //Configure cookie
                newCookie.Domain = "yoursite.com";
                newCookie.Expires = new DateTime(2018, 12, 1);
                newCookie.Name = "UserName";
                newCookie.Path = "/";
                newCookie.Secure = false;
                newCookie.Value = "Hey Welcome to Cookies Example";

                sb.Append("Cookie retrieved from client. ");
                sb.Append("  Cookie Name: " + newCookie.Name + "  ");
                sb.Append("  Cookie Value: " + newCookie.Value + "  ");
                sb.Append("  Cookie Expiration Date: " + newCookie.Expires + "");



                    //Add cookie to response object
                    Response.Cookies.Add(newCookie);
               
                //Output cookie value to page
                // TextBox1.Text = Response.Cookies["Username"].ToString();

                TextBox1.Text = sb.ToString();

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Hey Cookie class members data displayed just now");
        }
    }
}