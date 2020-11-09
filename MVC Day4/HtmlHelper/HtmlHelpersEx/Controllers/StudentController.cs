using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using HtmlHelpersEx.Models;

namespace HtmlHelpersEx.Controllers
{
    public class StudentController : Controller
    {
        NorthwindEntities2 db = new NorthwindEntities2();
        public ActionResult Index()
        {
            return View();
        }

        //Strongly typed Helper
        public ActionResult StronglyTypedCreate()
        {
            return View();

        }
          //TemplatedHelper 1
        public ActionResult TemplatedHelper()
        {
            return View();

        }

        //TemplatedHelper 2
        public ActionResult EditorFormodelEg()
        {
            return View();

        }
        public ActionResult Create()
        {
            return View();
        }
        /// <summary>
        /// Using Request 
        /// </summary>
        /// <param name="RegionDescription"></param>
        /// <returns></returns>
        
        #region Request
        // [HttpPost]
        //[ActionName("Create")]
        //public ActionResult CreatePost()
        //{
        //    Region region = new Region();
        //    //region.RegionID = Convert.ToInt32(Request["RegionID"]);
        //    region.RegionDescription = Request["RegionDescription"].ToString();
        //    db.Regions.Add(region);
        //    db.SaveChanges();


        //    return View();
        //}
        #endregion

    /// using parameter
    
        [HttpPost]
        public ActionResult Create(string RegionDescription)
        {
            Region r = new Region();
           // r.RegionID = RegionID;
            r.RegionDescription = RegionDescription;
            db.Regions.Add(r);
            db.SaveChanges();
            return View();
        }
        

       
        
    }
}