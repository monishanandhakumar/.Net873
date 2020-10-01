using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopandConditionalStatementEg
{
    //print all even numbers btw 1...n
    /*while(condition)
     {
       set of statements
      }*/
      /*do
       * {
       * set of statements
       * }while(condition)*/
    class WhileEg
    {
        static void Main()
        {
            int  endvalue ,initialvalue=1;
            Console.WriteLine("Enter the number");
            endvalue = Convert.ToInt32(Console.ReadLine());
            /*     while(initialvalue<=endvalue)
                 {
                   //  Console.WriteLine("initialvalue:{0}",initialvalue);
                     initialvalue++;
                     if(initialvalue%2==0)
                     {
                         Console.WriteLine("{0} is even",initialvalue);
                     }
                 }*/

            while(initialvalue>endvalue)
            {
                Console.WriteLine("inside while");
            }
            Console.WriteLine("------------------");
            do
            {
                Console.WriteLine("Inside Do While ");
                Console.WriteLine("initialvalue:{0}", initialvalue);
                initialvalue++;
            } while (initialvalue > endvalue);


            Console.Read();
        }
    }
}
