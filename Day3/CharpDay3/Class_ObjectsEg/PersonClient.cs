using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_ObjectsEg
{
    class PersonClient
    {
        static void Main()
        {
            Person person = new Person();
            person.name = "Sai";
            person.age = 45;
            person.DisplayPerson();
            Console.Read();
        }
    }
}
