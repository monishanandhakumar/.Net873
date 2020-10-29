using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace stateexamples
{
    public partial class querydest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //first method

              Label1.Text = Request.QueryString["uname"].ToString();
            Label2.Text = Request.QueryString["contact"].ToString();

            //second method

            //string temp;
            //temp = "Name:" + (Request.QueryString["QS1"].ToString());
            //temp += "--Contact:" + Request.QueryString["QS2"].ToString();
            //Label1.Text = temp;

        }
    }
}