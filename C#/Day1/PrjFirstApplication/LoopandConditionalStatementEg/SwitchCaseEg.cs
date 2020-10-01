using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopandConditionalStatementEg
{
    /*switch(case)
     * {
     * case 1: statements; break;
     * case 2:set of statements;break;;
     * 
     * case n:set of statements;break;
     * default:set of statements;break;
     }
         */
    class SwitchCaseEg
    {

        static void Main()
        {
            #region switcheg1
            /* int num;
            Console.WriteLine("Enter the number");
            num = Convert.ToInt32(Console.ReadLine());
            

           switch(num)
            {
                case 1:
                    {
                        Console.WriteLine("Monday");
                        break;
                    }
                
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("saturday");
                    break;
                default:
                    Console.WriteLine("Invalid number");
                    break;
            }*/
            #endregion

            #region switcheg2
            Console.WriteLine("Enter the value of input1 and input2");
            int input1 = Convert.ToInt32(Console.ReadLine());
            int input2 = Convert.ToInt32(Console.ReadLine());
            int result;
            Console.WriteLine("Enter the operation to be performed");
            string operation = Console.ReadLine();
            switch (operation)
            {
                case "+":
                    {
                        result = input1 + input2;
                        Console.WriteLine("Addition:{0}", result);
                        break;
                    }
                case "-":
                    { 
                    result = input1 - input2;
                    Console.WriteLine("subtraction:{0}", result);
                    break;
                    }
                default:
                    Console.WriteLine("Invalid Operation");
                    break;
            }

            #endregion

            Console.Read();
        }
    }
}
