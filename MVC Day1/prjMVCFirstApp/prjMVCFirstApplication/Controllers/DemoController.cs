using prjMVCFirstApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prjMVCFirstApplication.Controllers
{
    public class DemoController : Controller
    {
        //ActionMethod
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }

        //Normal Method returns string
        public string NormalMethod()
        {
            return "Hi All!!";
        }
        //ActionMethod  returing ActionResult
        //1
        public ActionResult FirstMethod()
        {
            return View();
        }

        //ActionMethod  returing ViewResult
        //2
        public ViewResult SecondMethod()
        {
            return View();
        }
        //3
        //Only for displaying set of strings --returns content in html page
        public ContentResult Reply()
        {
           // return Content("Good Morning All!!!", "text/plain");
          return Content("<h1>Good Morning All!!!</h1>","text/html");
        }

        // 4 Empty result
        [NonAction]
        public EmptyResult Result()
        {
            int amount = 45000;
            float SI = (amount * 3 * 2) / 100;
            return new EmptyResult();
        }
        //Return as json result
        public JsonResult Empdata()
        {
            Employee employee = new Employee();
            employee.id = 101;
            employee.name = "Sunil";
            employee.age = 25;
            return Json(employee, JsonRequestBehavior.AllowGet);
        }

    }
}