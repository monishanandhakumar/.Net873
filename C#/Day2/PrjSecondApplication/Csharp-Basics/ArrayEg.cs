using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Basics
{
    //Array is collection of homogeneous(same) data type
    class ArrayEg
    {
        static void Main()
        {
            int i;
            //One-Dimensional Array
            //data type[] arrname=new datatype[size];
            //data type[] arrname=new datatype[size]{value1,value2,..valueN};
            //new--allocates memory
            string[] flower = new string[4]; //0 ,1,2,3

            flower[0] = "Lily";
            flower[1] = "rose";
            flower[2] = "Jasmine";
            flower[3] = "Lotus";
            
           
            Console.WriteLine(flower[0]);
            for( i=0;i<flower.Length;i++)
            {
                Console.WriteLine("index{0}:{1}",i,flower[i]);
            }
           // int size=4;
            int[] marks = new int[4] {90,89,56,78};

          
            Console.WriteLine("Enter the array Size");
            int size = Convert.ToInt32(Console.ReadLine());
            string[] names = new string[size];//3
            //getting from the user
            // for(i=0;i<size-1;i++)
            for (i = 0; i < names.Length; i++) //0 1 2
            {
                Console.WriteLine("Enter the name for index{0}",i);
                names[i] = Console.ReadLine();
            }

            //displaying 
            for (i = 0; i < names.Length; i++)
            {
                Console.WriteLine("names{0}:{1}", i, names[i]);
            }

            Console.Read();
        }
    }
}
