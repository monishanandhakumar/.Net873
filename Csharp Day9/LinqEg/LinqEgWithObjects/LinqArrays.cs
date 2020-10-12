using System;
using System.Collections.Generic;
using System.Linq;
namespace LinqEgWithObjects
{

    class Student
    {
        public int Rollno { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Gender { get; set; }
      


        internal Student (int Rollno, string Name, string City, string Gender)
        {
            this.Rollno = Rollno;
            this.Name = Name;
            this.City = City;
            this.Gender = Gender;

        }
    }
    class LinqArrays
    {
        /*from < range variable > in < IEnumerable < T > or IQueryable<T> Collection>


     < Standard Query Operators> < lambda expression >


       < select or groupBy operator> < result formation >*/

        //Datasource
        string[] books = { "English", "Java", "Clouding Computing", "Grid Computing", "Devops" };

       static  int[] Marks = { 90,78, 98, 67, 89, 100 };
        #region Array
        void StringArray()
        {
            //Query synatx in LINQ
            //Sql :select * from tablename;
            //fetching all the information from books array

            var res = from b in books
                      select b;
            foreach (var bname in res)
            {
                Console.WriteLine(bname);
            }



            //fetch the books name conatins 'u'

            var iobj = from bo in books
                       where bo.Contains("Computing")
                       select bo;

            foreach (var bname in iobj)
            {
                Console.WriteLine(bname);
            }

        }
        #endregion

        #region IntegerArray
        //Relational Operator ,Aggregate Function
        static void IntergerArray()
        {
            //Min function
            Console.WriteLine("MiniumMarks:{0}",Marks.Min());
            //Max function
            Console.WriteLine("MaxiumnMarks:{0}",Marks.Max());
            IEnumerable<int> marray = from m in Marks
                                      where m > 70 && m < 100
                                      select m;

            foreach(var mobj in marray)
            {
                Console.WriteLine(mobj);
            }

            //No of students marks btw 70 and 100
            //Count
           int marray1 = (from m in Marks
                                      where m > 70 && m < 100
                                      select m).Count();
            Console.WriteLine("No of student marks btw 70 and 100 is:{0}",marray1);
        }
        #endregion

        #region List
        void  ListEg()
        {
            List<Student> stu = new List<Student>();
            stu.Add(new Student(101, "SRI", "Chennai", "male"));
            stu.Add(new Student(102, "Tarun", "Mahapha", "male"));
            stu.Add(new Student(103, "Nisha", "Mumbai", "female"));
            stu.Add(new Student(104, "Aruna", "Coimbatore", "female"));
            stu.Add(new Student(105, "Vidhay", "Chennai", "female"));

            //display the students from chennai
            //select * from students where city="Chennai"
            var studetails = from s in stu
                             where s.City.Equals("Chennai")
                             select s;

            foreach(var st in studetails)
            {
                Console.WriteLine(st.Rollno+" "+st.Name+" "+st.City);
            }

            //select name,city from student where city="Chennai"
            var studetails1 = from s in stu
                             where s.City.Equals("Chennai")
                             select new { n= s.Name,c=s.City};

            foreach (var st in studetails1)
            {
                Console.WriteLine(st.n + " " + st.c );
            }

        }
        #endregion

        #region OrderBy and GroupBy
        void OrderBy_GroubByEg()
        {
            List<Student> stu = new List<Student>();
          stu.Add(new Student(101, "SRI", "Chennai", "male"));
            stu.Add(new Student(102, "Tarun", "Mahapha", "male"));
            stu.Add(new Student(103, "Nisha", "Mumbai", "female"));
            stu.Add(new Student(104, "Aruna", "Coimbatore", "female"));
            stu.Add(new Student(105, "Vidhay", "Chennai", "female"));

            /*   IEnumerable<Student> st=  from s in stu
                                       orderby s.Name
                                          select s;*/

            //display  student details order by gender ,then by name

            IEnumerable<Student> st = from s in stu
                                      orderby s.Gender,s.Name
                                      select s;
            foreach (var stud in st)
            {
                Console.WriteLine("{0}   {1}  {2}",stud.Name,stud.City ,stud.Gender);
            }
            Console.WriteLine("----------------GroupBy-------------------");
            Console.WriteLine("No of males and females");
            var gendercount = from s in stu
                              group s by s.Gender;
            foreach(var g in gendercount)
            {
                Console.WriteLine(g.Key+" "+g.Count());
            }

        }

        #endregion
        static void Main()
        {

            LinqArrays linqArrays = new LinqArrays();
            // IntergerArray();

            // linqArrays.ListEg();
            linqArrays.OrderBy_GroubByEg();



            Console.Read();
        }
    }
}
