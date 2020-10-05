using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_ObjectsEg
{
    class Movie
    {
        int id;
        string moviename;
      //  DateTime year;

      internal  Movie(int id,string moviename)

        {
            this.id = id;
            this.moviename = moviename;
          //  this.year = year;
        }

      internal  void DisplayMovie()
        {
            Console.WriteLine("id:{0}||Moviename:{1}",id,moviename);
        }

    }
    class ArrayofObjectEg
    { 
        static void Main()
        {
            Movie movie = new Movie(101,"Dangal");
            movie.DisplayMovie();
            //applying array to objects to fetch multiple movie info
            //array of object
            //datatype[] arrayname=new datatype[size];
            //static
           Movie[] mov = new Movie[2];
            mov[0] = new Movie(102, "Roja");
            mov[1] = new Movie(103, "Boss");

            for(int i=0;i<2;i++)
            {
                mov[i].DisplayMovie();
            }
            Console.Read();
        }
    }
}
