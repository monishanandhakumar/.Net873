using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using prjStoredProcedureEg.Models;

namespace prjStoredProcedureEg.Controllers
{
    public class AccessForeignKeyController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: AccessForeignKey
        public ActionResult Index()
        {
            return View();
        }

        //Binded with Territories table
        public ActionResult Create()
        {
            ViewBag.Regionid = (from t in db.Territories
                                select t.RegionID).Distinct();

            ViewBag.Regiondescription = (from t in db.Territories
                                         join r in db.Regions
                                         on t.RegionID equals r.RegionID
                                select r.RegionDescription).Distinct();

            return View();
        }
        [HttpPost]

        public ActionResult Create(Territory territory)
        {
            ViewBag.Regionid = (from t in db.Territories
                                select t.RegionID).Distinct();

            ViewBag.Regiondescription = (from t in db.Territories
                                         join r in db.Regions
                                         on t.RegionID equals r.RegionID
                                         select r.RegionDescription).Distinct();


            var rid = territory.RegionID;
            ViewBag.Regionid = (from t in db.Regions
                               
                                select t.RegionID).Distinct();

            db.Territories.Add(territory);
            db.SaveChanges();

            return View();
        }
    }
}