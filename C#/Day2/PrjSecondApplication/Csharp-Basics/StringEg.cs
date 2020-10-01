using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Basics
{
    class StringEg
    {
        static void Main()
        {
           String firstname = "Monisha Devi";
            Console.WriteLine("Length of the string:{0}",firstname.Length);
            Console.WriteLine("converting to uppercase{0}",firstname.ToUpper());
            Console.WriteLine("contains :{0}", firstname.Contains("sha"));
            Console.WriteLine("Index s:{0}",firstname.IndexOf("s"));
            Console.WriteLine("Checks wheather " +
                "first character starts with :{0}",firstname.StartsWith("G"));

            Console.Read();
        }
    }
}
