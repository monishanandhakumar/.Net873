using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace prjCodeFirstEg.Models
{
    [Table("tblCar")]  //using System.ComponentModel.DataAnnotations.Schema;

    public class Car
    {
        [Key]//using System.ComponentModel.DataAnnotations;

        public int carno { get; set; }
        public string carname { get; set; }
        public string cartype { get; set; }
    }
}