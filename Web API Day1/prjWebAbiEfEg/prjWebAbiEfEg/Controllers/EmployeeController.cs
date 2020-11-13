using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using prjWebAbiEfEg.Models;
namespace prjWebAbiEfEg.Controllers
{
    public class EmployeeController : ApiController
    {
        SampleEntities db = new SampleEntities();
        [Route("getemployee")]
        public HttpResponseMessage GET()
        {
            var Employees = db.employees.ToList();
            if (Employees.Count > 0)
            {
                return Request.CreateResponse(HttpStatusCode.OK, Employees);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "No Data Found");
            }

        }

        //get by gender
        public HttpResponseMessage Get(string gender = "All")
        {
            switch (gender.ToLower())
            {
                case "all":
                    return Request.CreateResponse(HttpStatusCode.OK,
                        db.employees.ToList());
                case "male":
                    return Request.CreateResponse(HttpStatusCode.OK,
                        db.employees.Where(e => e.gender.ToLower() == "male").ToList());
                case "female":
                    return Request.CreateResponse(HttpStatusCode.OK,
                         db.employees.Where(e => e.gender.ToLower() == "female").ToList());
                default:
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest,
                        "Value for gender must be Male, Female or All. " + gender + " is invalid.");
            }

        }


        //put

        public HttpResponseMessage Put(int id, employee eobj)
        {
            try
            {
                    var entity = db.employees.FirstOrDefault(e => e.emp_id == id);
                    if (entity == null)
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound,
                        "Employee with Id " + id.ToString() + " not found to update");
                    }
                    else
                    {
                        entity.name = eobj.name;
                        entity.city = eobj.city;
                        entity.age = eobj.age;
                        entity.gender = eobj.gender;
                        entity.mobile = eobj.mobile;
                        db.SaveChanges();
                        return Request.CreateResponse(HttpStatusCode.OK, entity);
                    }
                
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
