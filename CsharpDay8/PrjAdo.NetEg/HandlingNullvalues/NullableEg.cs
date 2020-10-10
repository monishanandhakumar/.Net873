using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingNullvalues
{
    class NullableEg
    {
        static void Main()
        {
            //nullable
            int? age =45;
            float? salary = 90000.00f;

            string fName = null;
            //Null coalescing Operator
            int res = age ?? 0;
            Console.WriteLine(fName??"Please enter valid name");
            Console.WriteLine(res);
            /* if (age != null)
             {
                 Console.WriteLine("age:{0}", age);
             }
             else
             {
                 Console.WriteLine("Age is null: Please enter the valid age");
             }*/


            Console.Read();

        }
    }
}
