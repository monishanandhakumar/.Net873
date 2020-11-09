using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace HtmlHelpersEx.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }
        //Standard HTML Helper
        public ActionResult Createregistration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Createregistration(FormCollection frm)
        {
            string fname = frm["txtName"].ToString();
            string gender = frm["Gender"].ToString();
            bool cooking = Convert.ToBoolean(frm["C"].Split(',')[0]);
            bool sports = Convert.ToBoolean(frm["S"].Split(',')[0]);
            bool art = Convert.ToBoolean(frm["A"].Split(',')[0]);
            string interest = "";
            if (cooking == true)
                interest = "cooking";
            if (sports == true)
                interest += "sports";
            if (art == true)
                interest += "art";
            string city = frm["City"].ToString();
            StringBuilder sb = new StringBuilder();
            sb.Append(fname + "</br>");
            sb.Append(gender + "</br>");
            sb.Append(interest+ "</br>");
            sb.Append(city);
            return Content(sb.ToString());
        }

    }
}