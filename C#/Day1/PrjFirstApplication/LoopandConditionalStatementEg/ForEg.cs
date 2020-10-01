using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopandConditionalStatementEg
{
    class ForEg
    {
        static void Main()
        {
            int table,n;
            Console.WriteLine("Enter the table to be printed");
            table = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number ");
            n= Convert.ToInt32(Console.ReadLine());
           //for(initialization;condition;increment/decrement)
           for(int i=1;i<=n;i++)  //i+=2=>i=i+2
            {
                int t = i * table;
                Console.WriteLine("{0} *{1}={2}",i,table,t);
                Console.WriteLine("--------------------------");
                //optimized 
                Console.WriteLine("{0} *{1}={2}", i, table, (i*table));
            }
            Console.Read();

        }
    }
}
