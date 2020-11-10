using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prjLayoutAuth.Controllers
{
    public class HomeController : Controller
    {
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

        public ActionResult Movies()
        {
            ViewBag.Message = "MoviesPage";

            return View();
        }

        public ActionResult Booking()
        {
            ViewBag.Message = "BookingPage";

            return View();
        }

        public ActionResult Feedback()
        {
            ViewBag.Message = "Feedback page.";

            return View();
        }
    }
}