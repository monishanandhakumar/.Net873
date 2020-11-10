using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prjLayoutAuth.Controllers
{
    public class UserAutheticationController : Controller
    {
        // GET: UserAuthetication
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection frm)
        {
            //  from r in db.Customer  r.email==frm["txtuname"].toString()&

            /*from s in db.register
            where(s.EmailId == r.Username && s.Password==r.Password)
             select s.Password;*/
            if (frm["txtuname"] == "Rani" && frm["txtpwd"] == "123")
            {
                Session["Loginstatus"] = "valid";
                Session["UserId"] = frm["txtuname"];
                return RedirectToAction("Index");
            }
            else
            {
                Session["Loginstatus"] = "Invalid";
                return View();

            }
        }


        public ActionResult LogOff()
        {
            Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}