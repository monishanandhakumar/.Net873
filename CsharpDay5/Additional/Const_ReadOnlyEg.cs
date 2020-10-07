using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional
{
    class ConstEg
    {
        //Compile time Constant
        public const float pi = 3.14f;
        const int value = 10 + 20;
        //non constant variable
        int data = 80;
        /*
        //error
         pi = 89.0; 
        const int add = 10 + data;
        static  const int value1 = 10 + 20;*/
        
    internal void PerimeterofCircle(int radius)
        {
            const string name = "JAI";
            // pi = 89.0; //error
            Console.WriteLine("PerimeterofCircle:{0}", (2 * pi * radius));
        }
    }

    class ReadonlyEg
    {
        //Run Time Constant
        internal readonly string SchoolName;
        internal static readonly string OrgName = "L&T";

        internal ReadonlyEg(string SchoolName)
        {
            this.SchoolName = SchoolName;
        }

        void DisplayStudent()
        {
            //Error
            //SchoolName = "MN";
        }
    }

    class Const_ReadOnlyEg
    {
        static void Main()
        {
            ReadonlyEg readonlyEg = new ReadonlyEg("ZAIN");
            ReadonlyEg r2 = new ReadonlyEg("KV");
            ConstEg c = new ConstEg();
            c.PerimeterofCircle(4);
            Console.Read();

        }
       
    }
}
