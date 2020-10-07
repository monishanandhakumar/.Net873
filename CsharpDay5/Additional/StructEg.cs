using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional
{
    //a structure is a value type data type. It helps you to make a
    //single variable hold related data of various data types

    /*Access_Modifier struct structure_name
{

   // Fields 
   // Parameterized constructor 
   // Constants 
   // Properties 
   // Indexers 
   // Events 
   // Methods etc.
   
}*/

   public struct Pen
    {
       internal int penid;
       public string color;
        //error
       // string type = "Fountain";
    }

    class StructEg
    {
        static void Main()
        {
            Pen p = new Pen();
            p.penid = 100;
            p.color = "red";
        }
    }
}
