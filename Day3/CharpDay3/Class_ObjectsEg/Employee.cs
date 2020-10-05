using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_ObjectsEg
{

    
    class Employee
    {
        //private
       string Name;
        int age;
        string degree;

        void DisplayDetails()
        {
            Console.WriteLine("Name:{0}||Age:{1}||Degree:{2}",Name,age,degree);
        }
        static void Main()
        {
             Employee employee1 = new Employee();
           
            employee1.Name = "Mani";
            employee1.age = 23;
            employee1.degree = "B.Tech";
            employee1.DisplayDetails();//display mani info
           Employee employee2 = new Employee();
            employee2.Name = "Sasi";
            employee2.age = 34;
            employee2.degree = "MS";
            employee1.DisplayDetails(); //Mani info
            employee2.DisplayDetails(); // sasi info
            Console.Read();

        }
    }
}
