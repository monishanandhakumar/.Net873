//header file in .net we call this as namespace
using System;

namespace BasicsEg
{
    class HelloWorldEg
    {
        static void Main()
        {
            //to print in console window
         
              Console.Write("Hello World");

            //To print 
            Console.WriteLine("Hello World");

            Console.WriteLine("-----------------------");
            //print your Name
            string myname = "Monisha " ,FatherName="Raj";

            Console.WriteLine(myname);

            //Concatenation
            //printf("Myname:%c",myname)
            Console.WriteLine("Concatenation");
            Console.WriteLine("MyName:"+myname);
            Console.WriteLine("---------------------");
            //Place holder
            Console.WriteLine("Placeholder");
            Console.WriteLine("MyName:{0}", myname);
            Console.WriteLine("MyName:{0} ||Fathername:{1}", myname,FatherName);

            Console.WriteLine("MyName:{1}  {0}", myname, FatherName);
            //to read from console window
            Console.Read();

        }
    }
}
