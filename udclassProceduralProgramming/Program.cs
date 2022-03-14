using System;

namespace udclassProceduralProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Input your name!");
             var name = Console.ReadLine();

             var arr = new char[name.Length];
             for (var i = name.Length; i > 0; i--)
                 arr[name.Length - i] = name[i - 1];

             var reversed = new string(arr);

             Console.WriteLine(reversed);*/

            Console.WriteLine("Input your name!");
            var name = Console.ReadLine();

            Console.WriteLine(ReveresedString(name));

        }

        public static string ReveresedString(string name)
        {
            var arr = new char[name.Length];//

            for (var i = name.Length; i > 0; i--)
                arr[name.Length - i] = name[i - 1];
            return new string(arr);

        }
    }
}
