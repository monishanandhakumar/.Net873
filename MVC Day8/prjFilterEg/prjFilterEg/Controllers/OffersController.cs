using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prjFilterEg.Controllers
{
    //Controller level Authorization
    [HandleError]
    [Authorize]
    public class OffersController : Controller
    {
        // GET: Offers
       
        public ActionResult OfferIndex()
        {
            return View();
        }
        public ActionResult BagOffer()
        {
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