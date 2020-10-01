using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsEg
{
    class Methodwithparameters
    {
        void ByValue(string p)
        {
            p = "000000000000";
            Console.WriteLine("Value changed inside method :ph:{0}",p);
        }

        void ByReference(ref string ph)
        {
            ph = "111111111111";
            Console.WriteLine("Value changed inside method :ph:{0}", ph);
        }

        static void Main()
        {
            string phno = "995278901";
            Methodwithparameters mobj = new Methodwithparameters();
            Console.WriteLine("before calling byvalue method:phno:{0}",phno);
            mobj.ByValue(phno);
            Console.WriteLine("after calling byvalue method:phno:{0}", phno);
            Console.WriteLine("----------------------------------");
            Console.WriteLine("before calling byvalue method:phno:{0}", phno);
            mobj.ByReference(ref phno);
            Console.WriteLine("after calling byvalue method:phno:{0}", phno);
            Console.Read();

        }
    }
}
