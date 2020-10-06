using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Organization //Parent class or base class
    {
        //Protected:only child class can access the information of parent class
      protected string Orgname="LTI";
        protected string location;


      protected void DisplayOrg()
        {
            Console.WriteLine("Orgname:{0}||Location{1}",Orgname,location);
        }
    }

    //Inheritance
    class Employee:Organization//Employee child or derived class
    {
        int Eid=1001;
        float salaryperhour=3200.00f;

       internal void DisplayEmployee()
        {
            //DisplayOrg();
            Console.WriteLine("Eid:{0}||salary:{1}||orgname{2}",Eid, salaryperhour, Orgname);
        }

        static void Main()
        {
            // Organization organization = new Organization();
            //organization.DisplayOrg();
            Employee employee = new Employee();
            //accessing parent class information through child class object
            employee.location = "Chennai";
            employee.DisplayOrg();
            employee.DisplayEmployee();

            Console.Read();
        }
    }
    class SingleInheitanceEg
    {
        
    }
}
