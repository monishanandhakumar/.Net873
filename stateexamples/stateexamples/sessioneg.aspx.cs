using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace stateexamples
{
    public partial class sessioneg : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["Country"] = TextBox1.Text;
            Application["whole"] = 1;
            Label1.Text = Session["Country"].ToString();

        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Label1.Text = Application["whole"].ToString();
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(Application["whole"]);
            i = i + 1;
            Application["whole"] = i;
            Label1.Text = Application["whole"].ToString();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("The current no of users logged in is :" + Application["SessionCount"]);
            DropDownList1.Items.Add("Chennai");
            DropDownList1.Items.Add("Bangalore");

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}