using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsConcept
{
    //generic has data type parameter is 'T'
    // a class can have both generic and non generic methods
    class Sample<T>
    {
        T oil;
       
        internal Sample(T oil)
            {
            this.oil = oil;
            }
        //Normal Method
        void SwapofNumber(int n1,int n2 )
         {
             int t;
             t = n1;
             n1 = n2;
             n2 = t;
         }

            //Generic Method
      internal   void Swap<T>(T n1, T n2)
        {
            T t;
            t = n1;
            n1 = n2;
            n2 = t;
            Console.WriteLine("n1:{0}||n2:{1}",n1,n2);
        }

    }

    class GenericMethod_ClassEg
    {
        static void Main()
        {
            Sample<string> sample = new Sample<string>("10liter");
            Sample<int> s1 = new Sample<int>(10);
            sample.Swap<int>(5, 6);
            sample.Swap<string>("you","ME");
            Console.Read();
        }
    }
}
