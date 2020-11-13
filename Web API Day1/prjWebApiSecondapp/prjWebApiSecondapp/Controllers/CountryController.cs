using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using prjWebApiSecondapp.Models;

namespace prjWebApiSecondapp.Controllers
{
    //3
    public class CountryController : ApiController
    {
        [Route("countrylist")]
        public HttpResponseMessage Get()
        {
            // list of Countries
            List<Country> Countries = new List<Country>();
            Country country = new Country();
            country.Id = 1;
            country.CountryName = "India";
            country.Capital = "Delhi";
            Countries.Add(country);

            //Countries to the response body.             
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, Countries);
            return response;
        }

        public IHttpActionResult Get(int id)
        {
            // list of Countries
            List<Country> Countries = new List<Country>();
            Country country = new Country();
            country.Id = 1;
            country.CountryName = "USA";
            country.Capital = "Washington";
            Countries.Add(country);

            //finding country based on provided id
            var result = Countries.FirstOrDefault(x => x.Id == id);
            if (result == null)
            {
                //create a 404 (Not Found) response
                return NotFound();
            }
            else
            {
                //creates a 200 (OK) response that contains the country
                return Ok(result);
            }
        }
    }
}
