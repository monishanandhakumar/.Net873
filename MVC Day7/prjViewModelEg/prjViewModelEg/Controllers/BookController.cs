using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prjViewModelEg.Controllers
{
    //Attribute Routing 
    [RoutePrefix("Book")]
    public class BookController : Controller
    {
        // GET: Book
        // [Route("Books")]
        [Route("All")]
        public ActionResult GetAllBooks()
        {
            return View();
        }
        //byid
        // [Route("Book/{id:int}")]
        [Route("id/{id:int?}")]
        public ActionResult GetBookbyid()
        {
            return View();
        }

        // [Route("Book/{name=Ram}")]
        [Route("{name=Ram}")]
        public ActionResult GetBookbyauthor()
        {
            return View();
        }

        //Route Constraint
        //  [Route("Book/{name:maxlength(4)}")]
        [Route("{name:maxlength(4)}")]
        public ActionResult GetBookByName(string name)
        {
            return View();
        }
    }
}