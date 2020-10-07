using System;


namespace ExceptionHandlingEg
{
    class SystemExceptionEg
    {
       
        static void Main()
        {
            int num = 30;
            string[] fruits = {"Orange","Mango" };
            int[,] arr = { { 10, 20,90 }, { 30, 40,80} };
           // num = num / 0;
              try
              {
                Console.WriteLine("num :{2}",num);
                Console.WriteLine("Fruit[2]:{0}",fruits[2]);
                num = num / 0;
               int add = 10 + 30;
                Console.WriteLine("Addition:{0}",add);
            }
            //Exception is handled


            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Message:{0}", ex);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Message:{0}", ex);
            }
           catch (Exception ex)
            {
                // Console.WriteLine("Message:{0}",ex);
                Console.WriteLine("Message:{0}", ex.Message);
                Console.WriteLine("Source:{0}", ex.Source);
                Console.WriteLine("Message:{0}", ex.StackTrace);
                Console.WriteLine("Please Check the inputs");
            }
            finally
            {
                Console.WriteLine("Used to close opened connection");
            }
            num = num * num;
            Console.WriteLine("multiplication:{0}",num);
            Console.WriteLine("End of systemexception");
          
            Console.Read();
            
        }
    }
}
