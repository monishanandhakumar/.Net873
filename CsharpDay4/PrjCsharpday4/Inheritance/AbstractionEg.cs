using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
   abstract class RBI
    {
        int empno = 20;
       public  abstract int Homeloan();
        public abstract int Educationloan();

        //Non abstract method
        internal void RBIEmployee()
        {
            Console.WriteLine("RBI Employee details:{0}",empno);
        }
    }
    class SBI:RBI
    {
        public override int Homeloan()
        {
            return 9;
        }
       public override int Educationloan()
        {
            return 10;
        }
    }
    class HDFC : RBI
    {
        public override int Homeloan()
        {
            return 10;
        }
        public override int Educationloan()
        {
            return 11;
        }
    }
    class AbstractionEg
    {
        static void Main()
        {
            //cant create object for abstract class
            // RBI r = new RBI();
            //reference for rbi class

            // SBI sbi = new SBI();
            /* sbi.RBIEmployee();
            Console.WriteLine("sbi h loan:{0}",sbi.Homeloan());
            Console.WriteLine("sbi e loan:{0}", sbi.Educationloan());
            HDFC hdfc = new HDFC();
            Console.WriteLine("hdfc h loan:{0}", hdfc.Homeloan());
            Console.WriteLine("hdfc e loan:{0}", hdfc.Educationloan());*/

            //Run Time Polymorphism
            RBI r;
            //object for SBI
            r = new SBI();
            r.RBIEmployee();
            Console.WriteLine("sbi h loan:{0}", r.Homeloan());
            Console.WriteLine("sbi e loan:{0}", r.Educationloan());
            r = new HDFC();
            Console.WriteLine("hdfc h loan:{0}", r.Homeloan());
            Console.WriteLine("hdfc e loan:{0}", r.Educationloan());
            Console.Read();
        }
    }
}
