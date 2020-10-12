using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEg
{
    class JumpingEg
    {
        static void Main()
        {
            int x = 5;
            start:
            x++;
            if(x<10)
            {
                goto start;
            }
            Console.WriteLine(x) ;
            Console.Read();
        }
    }
}
