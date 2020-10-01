using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsEg
{/*
    class class_name
{
    ...

    ...

    <Access_Specifier> <Return_Type> Method_Name(<Parameters>)

    {

        // Statements to Execute

    }

    ...

    ...

}

    */
    class Eg1
    {
       //Method with void return type
        void Welcome()
        {
            Console.WriteLine("Welcome All!!!");
           // return "hi";
        }
        //Method with string return type
        string GetName()
        {
            return "SRI";
        }
        //Method with int return type
        int GetAge()
        {
            return 22;
        }
        char GetInitial()
        {
            return 'K';
        }

        static void Main()
        {
            Eg1 eg1 = new Eg1();
           // eg1.Welcome();
            string name=eg1.GetName();
            Console.WriteLine("Name:{0}",name);
            Console.WriteLine("Age:{0}",eg1.GetAge());
            Console.WriteLine("Initial:{0}",eg1.GetInitial());
            Console.Read();
               
        }
    }
}
