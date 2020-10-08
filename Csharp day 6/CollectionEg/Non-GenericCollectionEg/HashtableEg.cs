using System;
using System.Collections;



namespace Non_GenericCollectionEg
{
    //accepts as key value pair
    //Not sorted 
    class HashtableEg
    {
        static void Main()
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "Monday");
            ht.Add(3, "Wednesday");
            ht.Add(4, "thursday");
            ht.Add("f", "Friday");
            ht.Add("fri", "Friday");

            foreach (DictionaryEntry d in ht)
            {
                Console.WriteLine(d.Key+ " "+d.Value);
            }

            Console.WriteLine("-------------SortedList-----------------");
            //Display the information in sorted order
            SortedList st = new SortedList();
            st.Add(1, "Monday");
            st.Add(4, "thursday");
            st.Add(3, "Wednesday");
            SortedList st1 = new SortedList();
            st1.Add("b", "bala");
            st1.Add("a","Anu");
          
            foreach (DictionaryEntry di in st1)
            {
                Console.WriteLine(di.Key + " " + di.Value);
            }
            Console.Read();
        }
    }
}
