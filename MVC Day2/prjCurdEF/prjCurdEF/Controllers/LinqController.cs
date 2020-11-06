using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using prjCurdEF.Models;

namespace prjCurdEF.Controllers
{
    public class LinqController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: Linq
        public ActionResult Index()
        {
            return View();
        }
        //Display the customer details group by region

       
        //Display the customer   whose is from  germany
        public ActionResult Customer()
        {
          List<Customer> customer=  (from c in db.Customers
                                  where c.Country == "germany"
                                  select c).ToList();
            return View(customer);
        }
        //display the employee details whoes region is notnull
        public ActionResult EmployeeRegionnotnull()
        {
            List<Employee> employees  = (from e in db.Employees
                                       where e.Region != null
                                       select e).ToList();
            return View(employees);
        }
        //display the customer info for orderid 10248
        public ActionResult ParticularOrderid()
        {

    List<Customer> customer=(from o in db.Orders
                          join
                      c in db.Customers
                    on o.CustomerID equals c.CustomerID
                    where o.OrderID==10248
                     select c
                     ).ToList();
            return View(customer);
        }
    }
}