using System;

namespace BasicsEg
{
    //scope of variable ,multiple methods in a class with return type
    class CalculaterEg
    {
        //global 
        float num1 = 80, num2 = 25, result;
        //method without return type
        void Add()
        {
            //local to the method
           // float num1 = 80, num2 = 25,result;

            //new space is created for result
            result = num1 + num2;
            Console.WriteLine("Addition is :{0}", result);
            //efficent
            Console.WriteLine("Addition is :{0}", (num1 + num2));

        }

        //Method with return type
       float Sub()
        {
            return (num1-num2);
        }

        static void Main()
        {
            //object creation
            //classname   object  = new classname()
            //function+f9 key to set break point
            CalculaterEg objcalci = new CalculaterEg();
            objcalci.Add();

            float res= objcalci.Sub();
            Console.WriteLine("sub:{0}",res );
            //optimized
            Console.WriteLine("Sub:{0}", objcalci.Sub());
            Console.ReadKey();

        }
    }
}
