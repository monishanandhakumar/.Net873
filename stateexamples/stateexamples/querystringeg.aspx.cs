using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace stateexamples
{
    public partial class quertstringeg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        //QueryString Example
        protected void Button1_Click(object sender, EventArgs e)
        {
            //First method

            Response.Redirect("querydest.aspx?uname=" + TextBox1.Text + "&contact=" +TextBox2.Text);

            //second method

            //string url;
            //url = "querydest.aspx?QS1=" + Server.UrlEncode(TextBox1.Text);
            //url += "&Qs2=" + TextBox2.Text;
            //Response.Redirect(url);

            

        }
    }
}