using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesOfClasses
{
    //Sealed by default 
    static  class OrgInfo
    {
    static  string oname = "LTI";
        static OrgInfo()
        {
            Console.WriteLine("Static Constructor");

        }
     internal static void DisplayOrg()
        {
            Console.WriteLine(oname);
        }
    }
    partial class Employee
    {

        internal void Getdata()
        {
            Console.WriteLine("get emp info");
        }
    }

    partial class Employee
    {

        public  void Displaydata()
        {
            Console.WriteLine("get emp info");
        }
    }
    class PartialEg
    {
        static void Main()
        {
            Employee e = new Employee();
            e.GetType();
            e.Displaydata();

            OrgInfo.DisplayOrg();
            Console.Read();
        }
    }
}
