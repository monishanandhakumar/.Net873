using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using prjFilterEg.Filters;

namespace prjFilterEg.Controllers
{
    [NoDirectAccess] //Actionfilter
    [HandleError]//ExceptionFilter
    [Authorize]//Authorizefilter
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        
        [Authorize(Users = "admin@gmail.com")]
        public ActionResult AddProduct()
        {
            return View();
        
        }
        [Authorize(Users = "admin@gmail.com")]
        public ActionResult DeleteProduct()
        {
            return View();

        }
        [AllowAnonymous]
        public ActionResult ViewProduct()
        {
            return View();

        }
        [Authorize(Users = "nisha@gmail.com")]
        public ActionResult Cart()
        {
            return View();

        }

        [HandleError(ExceptionType = typeof(DivideByZeroException), View = "DZError")]
        [AllowAnonymous]//Bypass authentication only for this action method
        public ActionResult AnotherProducts()
        {
            int num1 = 0, num2 = 10, result = 0;
            result = num2 / num1;
            
            return View();
        }

        public ActionResult Fruits()
        {
            string[] fruits = { "Mango", "Orange" };
            ViewBag.fruit = fruits[2];
            return View();
        }

    }
}