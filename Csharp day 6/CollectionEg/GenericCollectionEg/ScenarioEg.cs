using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionEg
{
    class Student  //database : table :student (name,id,age)
    {
        public string name { get; set; }
        public int id { get; set; }
        public int age { get; set; }

       public Student (string name, int id, int age)
        {
            this.name = name;
            this.id = id;
            this.age = age;
        }
    }

    class BusinessLayer
    {

        public void GetStudentDetails()
        {
           
        }
        public void Displaycity(string c)
        {
            Console.WriteLine("City:{0}",c);
        }

        public  void DisplayStudentDetails(List<Student> stu)
        {
            if(stu.Count!=0)
            {
                foreach (Student s in stu)
                { 
                    if(s.name !=null &&s.age!=0 && s.id!=0)  //  And :&&  ,  or:||
                    //Console.WriteLine(s.name+ " "+s.id+" "+s.age);
                    Console.WriteLine("id:{0}||name:{1}||age:{2}", s.id, s.name, s.age);
                    else
                        Console.WriteLine("Some values are null or 0 in the input .Please enter the valid input");
                }
            }
            else
            {
                Console.WriteLine("List is Empty!!!");
            }
        }

      
    }
    //UI
    class ScenarioEg
    {
        static void Main()
        {
            string city = "chennai";
          List<Student> students = new List<Student>();
            students.Add(new Student(null,1001,30));
            students.Add(new Student("Abi", 1002, 24));
            BusinessLayer businessLayer = new BusinessLayer();
            businessLayer.Displaycity(city);
            businessLayer.DisplayStudentDetails(students);
          
          /*  foreach(Student s in students)
            {
                //Console.WriteLine(s.name+ " "+s.id+" "+s.age);
                Console.WriteLine("id:{0}||name:{1}||age:{2}",s.id,s.name,s.age);
            }*/
            Console.Read();
        }
    }
}
