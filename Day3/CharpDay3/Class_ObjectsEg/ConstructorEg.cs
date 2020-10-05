using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_ObjectsEg
{
    class Pen
    {
         int ISBN;
        string brand;
        string color;
        //constructor--special method ,constructor name should be same that of your class name,by default :private 
        //Initialize the value for the variables
        //constructor dont have return type

       //Constructor overLoading
      internal  Pen() //no arguments
        {
            Console.WriteLine("Default Constructor");
        }
        internal Pen(int ISBN)// 1 argument
        {
            this.ISBN = ISBN;
            Console.WriteLine("ISBN");
        }
      internal  Pen(string b,string color) //2 arguments
        {
            brand = b;
            //refers to current class instance -->Pen
           this.color = color;
        }
       internal void DisplayPen()
        {
            Console.WriteLine("brand:{0}||color:{1}",brand,color);
        }
    }
    class ConstructorEg
    {
        static void Main()
        {
            //Object==Instance
            Pen p = new Pen(); //call constructor with no arguments
            Pen p1 = new Pen(12345); //call constructor with one arguments
            Pen pen = new Pen("parker","blue");//call constructor with two arguments
            //constructor
            /*  pen.brand = "Parker";
              pen.color = "blue";*/

            pen.DisplayPen();
            Console.Read();
        }
    }
}
