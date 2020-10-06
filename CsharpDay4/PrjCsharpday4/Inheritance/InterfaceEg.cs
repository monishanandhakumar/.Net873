using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    interface INormalCalculator
    {
        // int c = 10;

        //error
        /* internal void RBIEmployee()
         {
             Console.WriteLine("RBI Employee details:{0}", empno);
         }*/
        int Add(int a, int b); //by default interface methods abstract ,public 
        string CalcName();
    }

    class Computing: INormalCalculator, IScientificCalculator //Implements 
    {
        internal string GetName()
        {
            return " Computing";
        }
      public int Add(int a, int b)
        {
            return a + b;
        }
        //public keyword is not required when calling methods with interface names
       string INormalCalculator.CalcName()
        {
            return "INormalCalculator";
        }
       string IScientificCalculator.CalcName()
        {
            return "IScientificCalculator";
        }

    }
    class InterfaceEg
    {
        static void Main()
        {
            Computing computing = new Computing();
            Console.WriteLine("Addition:{0}",computing.Add(89,67));
            Console.WriteLine("Class Name:{0}",computing.GetName());
            IScientificCalculator s = new Computing();
            Console.WriteLine(s.CalcName());//IScientificCalculator 
            INormalCalculator r = new Computing();
            Console.WriteLine(r.CalcName()); // INormalCalculator
            Console.Read();
        }
    }
}
