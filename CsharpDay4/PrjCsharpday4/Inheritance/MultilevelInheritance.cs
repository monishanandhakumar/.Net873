using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class College
    {
        protected string id = "C101";
        // protected string CollegeName="MIT";
        protected string CollegeName;
        internal  College(string CollegeName)
        {
            this.CollegeName = CollegeName;
            Console.WriteLine("College Constructor");

        }
        ~College()
        {
            Console.WriteLine("College Destructor");
        }


    }

    class Department:College
    {
       protected string id = "d1000";
        // protected string Deptname="CSE";
        protected string Deptname;
       internal Department(string cname,string Deptname):base(cname)
        {
            this.Deptname = Deptname;
            Console.WriteLine("Department Constructor");
        }
     protected   void GetDept()
        {
            Console.WriteLine("collegeid :{0} ||Deptid:{1}",base.id,id);
            Console.WriteLine("collegename:{0}||Deptname:{1}",

               CollegeName, Deptname);
        }
~Department()
        {
            Console.WriteLine("DEpartment Destructor");
        }
    }
    class Student:Department
    {
        //string stuname="Mani";
        string stuname;
        Student(string cname,string Dname, string stuname):base(cname,Dname)
        {
            
            this.stuname = stuname;
            Console.WriteLine("student Constructor");
        }
        void DisplayStuInfo()
        {
            Console.WriteLine("collegename:{0}||Deptname:{1}||Student:{2}",
                
                CollegeName, Deptname, stuname);
        }


        static void Main()
        {
            Student student = new Student("MIT","MEch","Jamuna");
            student.GetDept();
            student.DisplayStuInfo();
            GC.Collect();
            Console.Read();
        }

        ~Student()
        {
            Console.WriteLine("Student destructor");
        }
    }
    class MultilevelInheritance
    {
        
    }
}
