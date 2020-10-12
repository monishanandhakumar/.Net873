using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DelegateEg
{
    public delegate void Calculate(int a, int b);
    class Calci
    {
        

        public void Sum(int a,int b)
        {
            Console.WriteLine("Sum is {0}",(a+b));
        }

        public void Multiplication(int a, int b)
        {
            Console.WriteLine("Multiplication is {0}", (a * b));
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Calci c = new Calci();
            //Without delegates
            c.Sum(6, 7);
            c.Multiplication(5, 4);
            //by delegates
            Calculate calculate1 = new Calculate(c.Sum);
            Calculate calculate2 = new Calculate(c.Multiplication);

            calculate1(8, 9);
            calculate2(7, 4);
            Console.Read();
        }
    }
}
