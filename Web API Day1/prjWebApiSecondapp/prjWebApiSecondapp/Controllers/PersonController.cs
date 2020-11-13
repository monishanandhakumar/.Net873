using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using prjWebApiSecondapp.Models;

namespace prjWebApiSecondapp.Controllers
{
    //2
    public class PersonController : ApiController
    {
        static List<Person> personlist = new List<Person>()
        {
            new Person {Id=1, Name = "Sai", City = "Hyderabad" },
            new Person {Id=2, Name = "Saranya", City = "Madurai" },
            new Person { Id = 3, Name = "Siva", City = "Chennai" }
        };

        //@model 
        //GET:api/person
        [Route("persondetails")]
        public IEnumerable<Person> Get()
        {
            return personlist;
        }

        //Http call by get id
        public IHttpActionResult GetPerson(int id)
        {
            Person person = personlist.Find(p => p.Id == id);
            return Ok(person);
        }

        // POST api/person
        //FormURI
      public void Post([FromUri]int Id,string Name,string City)
    {
            Person p = new Person();
            p.Id = Id;
            p.Name = Name;
            p.City = City;
        personlist.Add(p);
    }
        /* public void Post([FromBody]Person person)
         {
             //4
             personlist.Add(person);
         }*/

        // DELETE api/person/5
        public void Delete(int id)
        {
            //6
            personlist.RemoveAt(id);
          
        }

        //update
        // PUT api/values/5
        public void Put(int id, [FromBody]Person person)
        {
           
            personlist[id] = person;


        }

    }
}
