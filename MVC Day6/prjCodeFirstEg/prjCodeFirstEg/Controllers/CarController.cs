using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using prjCodeFirstEg.Models;

namespace prjCodeFirstEg.Controllers
{
    public class CarController : Controller
    {
        VechileContext db = new VechileContext();
        Car c = new Car();
        // GET: Car
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View(c);
        }

        [HttpPost]

        public ActionResult Create(Car car)
        {
            db.cars.Add(car);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}