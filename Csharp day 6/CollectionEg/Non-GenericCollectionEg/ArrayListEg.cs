using System;
using System.Collections;

namespace Non_GenericCollectionEg
{
    //colection of objects :heterogeneous,allows dynamic memory,duplicate elements,Index is zero based,
    //no supported for multidimension
    class ArrayListEg
    {
        static void Main()
        {
            int[] arr = { 90, 60, 89, 10, 34 };

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("After sorting");
            Array.Sort(arr);
           // for(int i=0;i<arr.Length;i++)
           //foreach(element in iterable-item )
           //var :implicit typed variable
           foreach( var item  in arr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------ArrayList-----------------");
            ArrayList al = new ArrayList();
            al.Add(10);   //al :object -->10:int //boxing While object ->int unboxing
            al.Add(78.90);
            al.Add("kalai");
            al.Add(90);
            al.Add("Kalai");
            al.RemoveAt(3);
            foreach (var item in al)
            {
                Console.WriteLine("ArrayList:{0}",item);
            }
            Console.WriteLine("count:{0}",al.Count);// no of elements in arraylist
            Console.WriteLine("capacity:{0}",al.Capacity);
            Console.WriteLine("Contains:{0}",al.Contains("Lalitha"));
           // Console.WriteLine("Contains:{0}", al.Reverse()); //when arraylist  has  homogeneous collection
            al.Remove(78.90);
            foreach (var item in al)
            {
                Console.WriteLine("ArrayList{0}:", item);
            }
            Console.Read();
        }
    }
}
