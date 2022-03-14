using System;
using System.Collections;
   using System.Collections.Generic;

namespace udclassLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>() { 1, 2, 3, 7, 8, 9 };

            list.Add(3); //

         
            list.AddRange(new int[3] {4,5,6 });//

           /* var li = new Stack();
            li.Push(4);

            list.InsertRange(3,(IEnumerable<int>)li);
           */
            foreach (var item in list)
                Console.Write(item);
            Console.WriteLine("\n -------");

            //indexof
            Console.WriteLine("Index of 3 is:"+ list.IndexOf(3));

            //lastindexof
            Console.WriteLine("last index of 3 is:" + list.LastIndexOf(3));

            //count
            Console.WriteLine("count :" + list.Count);

            //remove
            for (var i = 0; i < list.Count; i++)
            {
                if (list[i] == 3)
                    list.Remove(list[i]);
            }
            foreach (var item in list)
                Console.Write(item);

            Console.WriteLine("");
            //clear
            list.Clear();
            Console.WriteLine("count :" + list.Count);



        }
    }
}
