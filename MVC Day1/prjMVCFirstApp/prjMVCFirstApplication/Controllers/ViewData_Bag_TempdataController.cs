using prjMVCFirstApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prjMVCFirstApplication.Controllers
{
    public class ViewData_Bag_TempdataController : Controller
    {
        // GET: ViewData_Bag_Tempdata
        public ActionResult Index()
        {
            int a = 10;
            dynamic b;
            b = 10;
            b = "kilo";
            b = 10.05f;
            List<string> s = new List<string>();
            b = s;
            return View();
        }

        public ActionResult Rules()
        {

            List<string> rule = new List<string>()
            {"Avoid T-shirt","Carry your Id Card"};
            
            //Both viewbag and viewdata used to transfer data from controller to view
            //Dynamic Property
            //ViewBag.variablename=value;
            ViewBag.getrules = rule;

            //Not a dynamic Property
            //ViewData["variablename"]=value;
            ViewData["follow"] = rule;
            return View();
        }

        public ActionResult FirstRequest()
        {
            List<string> TempDataTest = new List<string>();
             TempDataTest.Add("Tejas");
             TempDataTest.Add("Jignesh");
             TempDataTest.Add("Rakesh");
             TempData["Emp"] = TempDataTest;
        
          //To retain data for any no of subsequent request
           TempData.Keep();
            return View();
        }

        public ActionResult SecondRequest()
        {
           List<string> n=TempData["Emp"] as List<string>;
            
            return View(n);
        }
    }
}