using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using prjCurdEF.Models;

namespace prjCurdEF.Controllers
{
    public class MultipleTableController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: MultipleTable
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult OrderCustomerInfo()
        {
            return View(db.Orders.ToList());
        }

        public ActionResult ExpandEg()
        {
            dynamic mymodel = new ExpandoObject();
            mymodel.Customerlist = db.Customers.ToList();
            mymodel.Orderlist = db.Orders.ToList();
            return View(mymodel);

        }
    }
}