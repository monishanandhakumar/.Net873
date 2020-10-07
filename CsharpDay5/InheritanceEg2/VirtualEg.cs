using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceEg2
{
    class InterviewRound1
    {
        //virtual or abtract method cant be private,it can be internal,protected,public ,protected internal
       internal virtual void Result()
        {
            Console.WriteLine("Round1:Cleared:7/10");
        }

        public int Score()
        {
            return 7;
        }
    }

    class InterviewRound2: InterviewRound1
    {
        //virtual or abtract method cant be private,it can be internal,protected,public ,protected internal
        internal override void Result()
        {
            base.Result();//Round1
            Console.WriteLine("Round2:Cleared:8/10");
            
        }

        //Hiding:new memory is created :not overriding
        public new  int  Score()
        {
            return 7;
        }
    }

    class InterviewRound3 : InterviewRound2
    {
        //virtual or abtract method cant be private,it can be internal,protected,public ,protected internal
        internal override void Result()
        {
            base.Result();//ROund2 
            Console.WriteLine("Round3:NotCleared:4/10");
        }
    }
    class VirtualEg
    {
        static void Main()
        {
           InterviewRound1 r1 = new InterviewRound1();
            // r1.Result();
            Console.WriteLine("Round1 Score:{0}",r1.Score()); 
            InterviewRound2 r2 = new InterviewRound2();
            //r2.Result();
            Console.WriteLine("Round2 Score:{0}", r2.Score());
            InterviewRound3 r3 = new InterviewRound3();
            r3.Result();
            Console.Read();
        }
    }
}
