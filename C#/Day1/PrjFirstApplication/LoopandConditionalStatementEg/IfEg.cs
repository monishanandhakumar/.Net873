using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopandConditionalStatementEg
{
    class IfEg
    {  
        //greatest of three numbers
        static void Main()
        {
            int num1 = 50, num2 = 40, num3 = 70;
            if(num1>num2 && num1>num3)
            {
                Console.WriteLine("Num1 is greater:{0}",num1);
            }
            else if(num2>num1 && num2>num3)
            {
                Console.WriteLine("Num2 is greater:{0}", num2);
            }
            else
            {
                Console.WriteLine("Num3 is greater:{0}", num3);
            }

            Console.Read();
        }
    }
}
