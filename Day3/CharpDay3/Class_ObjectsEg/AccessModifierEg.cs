using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_ObjectsEg
{
    //by default class is internal
    class Person
    {
      internal string name;
       internal int age;

    public void DisplayPerson()
        {
            Console.WriteLine("name:{0}||Age:{1}",name,age);
        }

    }
    class AccessModifierEg
    {
       
    }
}
