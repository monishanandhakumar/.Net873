using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Basics
{
    class Two_DimensionalArray
    {
        static void Main()
        {

            //datatype[,] arrname=new datatype[row,col];
            // int[,] matrix = new int[3, 3];
            /*   int[,] matrix = new int[2, 2] { {10,20 },{ 30,40} };
               for(int i=0;i<2;i++) //row
               {
                   for(int j=0;j<2;j++)//col
                   {
                       Console.WriteLine(matrix[i,j]);
                   }

               }*/

            Console.WriteLine("Enter rows");            int row = Convert.ToInt32(Console.ReadLine());            Console.WriteLine("Enter column");            int column = Convert.ToInt32(Console.ReadLine());            int[,] Matrix = new int[row, column];            //reading            for (int i = 0; i < row; i++)            {                for (int j = 0; j < column; j++)                {                    Console.WriteLine("Enter[{0}{1}]", i, j);                    Matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //displaying

            for (int i = 0; i < row; i++)            {                for (int j = 0; j < column; j++)                {                   // Console.WriteLine("Enter[{0}{1}]", i, j);
                    Console.Write(Matrix[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
