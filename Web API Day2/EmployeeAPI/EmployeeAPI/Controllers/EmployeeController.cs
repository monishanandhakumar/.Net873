using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EmployeeAPI.Models;

namespace EmployeeAPI.Controllers
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

    }
}
