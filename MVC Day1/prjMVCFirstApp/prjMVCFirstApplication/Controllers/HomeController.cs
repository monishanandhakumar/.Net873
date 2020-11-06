using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prjMVCFirstApplication.Controllers
{
    public class HomeController : Controller
    {
        //Action Methods
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult FeedBack()
        {
            ViewBag.Message = "Enter your Feedback";

            return View();
        }
    }
}