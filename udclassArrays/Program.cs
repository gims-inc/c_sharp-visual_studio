using System;

namespace udclassArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new[] {2,3,4,5,6,7,8,9 };
            //length
            Console.WriteLine("length: "+ arr.Length);
            //index
            var indx = Array.IndexOf(arr, 9);
            Console.WriteLine("index of 9: "+indx);
            //clear
            Array.Clear(arr,1 ,3);
            foreach (var elem in arr)
                Console.Write(elem);

            Console.WriteLine("");
            //copy
            int[] arrcopy = new int[4];
            Array.Copy(arr, arrcopy, 4);
            foreach(var elmc in arrcopy)
            Console.Write(elmc);

            Console.WriteLine("");
            //sort
            Array.Sort(arr);
            foreach (var elms in arr)
                Console.Write(elms);

            Console.WriteLine("");
            //Reverse
            Array.Reverse(arr);
            foreach (var elmr in arr)
                Console.Write(elmr);

        }
    }
}
