using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    
    class Car:Parts
    {
        static void Main()
        {
            Car c = new Car();

            c.wheel = 4;
            c.Motor = "V6";
            c.DisplayParts();
            
           
            Console.Read();
        }
    }
}
