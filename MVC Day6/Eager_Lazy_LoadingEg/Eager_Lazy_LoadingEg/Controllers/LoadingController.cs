using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Eager_Lazy_LoadingEg.Models;

namespace Eager_Lazy_LoadingEg.Controllers
{
    public class LoadingController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: Loading
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Lazyloading()
        {
            //display product details
            var p = (from pr in db.Products
                    select pr).ToList();

            //display suppliername and products supplied by supplier
            var su = (from s in db.Suppliers
                      join pr in db.Products
                      on s.SupplierID equals pr.SupplierID
                      select new {s.CompanyName,pr.ProductName }).ToList();
            return View(su);
        }

        public ActionResult EagerLoading()
        {
            //Disable Lazy Loading 
            db.Configuration.LazyLoadingEnabled = false;

            var sup = db.Suppliers.Include("Products").ToList();

            //Products supplied by particular supplier
            var supplier1 = (from s in db.Suppliers
                             .Include("Products")  //ProductModel table to be included in the result 
                             where s.SupplierID == 20
                             select s).ToList();
            return View(sup);
        }

    }
}