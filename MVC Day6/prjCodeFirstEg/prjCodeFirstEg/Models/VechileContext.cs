using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace prjCodeFirstEg.Models
{
    public class VechileContext:DbContext
    {
      public  VechileContext():base("name=efVehicles")
        {

        }

        public DbSet<Car> cars { get; set; }
    }
}