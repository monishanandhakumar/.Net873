using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace stateexamples
{
    public partial class hiddenfieldeg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HiddenField2.Value = TextBox1.Text;
            //HiddenField2.Value = TextBox2.Text;
            ViewState["nationality"] = TextBox2.Text;
            TextBox1.Text = "";
            TextBox2.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            // Label3.Text = "You Belong to " + HiddenField1.Value + " and your nationality is " + HiddenField2.Value;
            Label3.Text = "You Belong to " + HiddenField2.Value + " and your nationality is " + ViewState["nationality"];
        }
    }
}