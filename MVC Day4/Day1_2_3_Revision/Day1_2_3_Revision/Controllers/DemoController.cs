using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day1_2_3_Revision.Models;

namespace Day1_2_3_Revision.Controllers
{
    //Collection of Action Methods
    public class DemoController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DisplayInfo()
        {
            ViewBag.empname = TempData["Ename"].ToString();
            return View();
        }

        public ViewResult DisplayInfo1()
        {
            return View();
        }
        //How to pass data from controller to view 
        //viewBag -dynamic:  ViewData-Dictionary (expicit type conversion is required)
        //TempData to transfer from actionMethod to actionMethod,Controller to controller,Controller to view
        public ActionResult Datafromcontrollertoview()
        {
            string name = "ABI";
            ViewBag.fname = name;
            ViewData["fname"] = name;
            TempData["Ename"] = "SRI";
            TempData.Keep();

            return View();
        }
        //StoredProcedure
        public ActionResult Sp()
        {
            return View(db.SalesByCategory("Confections","1996"));
        }
    }
}