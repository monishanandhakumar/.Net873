using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using prjStoredProcedureEg.Models;

namespace prjStoredProcedureEg.Controllers
{
    public class StoredProcedureController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: StoredProcedure
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TenProduct()
        {
            
            return View(db.Ten_Most_Expensive_Products());
        }
        public ActionResult Sales()
        {
            return View(db.SalesByCategory("Seafood", "1996"));
        }
       
    }
}