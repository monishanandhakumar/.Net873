using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace stateexamples
{
    public partial class viewstateeg : System.Web.UI.Page
    {
        string name;
        string pwd;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ViewState["name"] = TextBox1.Text;
            ViewState["pwd"] = TextBox2.Text;
            TextBox1.Text = "";
            TextBox2.Text = string.Empty;

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
          //  name = ViewState["name"];

            Label3.Text = "Your name is " + ViewState["name"] + "and password is" + ViewState["pwd"];
        }
    }
}