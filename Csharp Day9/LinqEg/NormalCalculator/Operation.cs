using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormalCalculator
{
    public class Operation
    {
        public void Divide(int a,int b)

        {

            try
            {
                Console.WriteLine("Divide:{0}",(a/b));
            }

            catch(Exception e)
            {
                Console.WriteLine(e);
            }

        }
    }
}
