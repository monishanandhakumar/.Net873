using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using prjCurdEF.Models;

namespace prjCurdEF.Controllers
{
    public class CategoryController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: Category
        public ActionResult Index()
        {
            return View();
        }
        #region Display
        //1  Fetching data from categories table
        public ActionResult GetCategoryDetails()
        {
                                //converting to list   
           List<Category> cate =db.Categories.ToList();
            return View(cate);
        }

        //Withscaffloding
        //2  Fetching data from categories table
        public ActionResult GetCategoryDetailsScaffold()
        {
            //converting to list   
            List<Category> cate = db.Categories.ToList();
            return View(cate);
        }
        #endregion

        #region Create
        //Adding new category details
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Category category)
        {
            db.Categories.Add(category);
            db.SaveChanges();
            return RedirectToAction("GetCategoryDetailsScaffold");
        }
        #endregion

        #region Delete
        public ActionResult Delete(int id)
        {
           Category category =db.Categories.Find(id);
            db.Categories.Remove(category);
            db.SaveChanges();
            return RedirectToAction("GetCategoryDetailsScaffold");
        }
        #endregion

        #region Display

        public ActionResult Details(int id)
        {
            Category category = db.Categories.Find(id);

            return View(category);
        }
        #endregion


        #region Edit
        public ActionResult Edit(int id)
        {
          Category category=  db.Categories.Find(id);
            return View(category);
        }

        [HttpPost]
        public ActionResult Edit(Category c)
        {
            Category category = db.Categories.Find(c.CategoryID);
            category.CategoryName = c.CategoryName;
            category.Description = c.Description;
            category.Picture = c.Picture;
            db.SaveChanges();
            return RedirectToAction("GetCategoryDetailsScaffold");
        }
        #endregion


        public ActionResult GetCategorybyname()
        {
            //Query Syntax
            //Display the categoryname in ascending order
            List<String> c = (from cat in db.Categories
                              orderby cat.CategoryName
                                select cat.CategoryName
                                ).ToList();


            //Method Syntax
           // dynamic c1= (db.Categories.OrderBy(ca => ca.CategoryName)).ToList();

            return View(c);
        }
    }
}