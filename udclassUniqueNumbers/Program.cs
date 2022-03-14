using System;
using System.Collections.Generic;

namespace udclassUniqueNumbers
{
    class ProgramMain
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();

            while (true)
            { 
            Console.Write("Enter a number or 'Quit' to exit!");

            var input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

                numbers.Add(Convert.ToInt32(input));
            }

            /*var uniques = new List<int>();

            foreach(var number in numbers)
            {
                if (!uniques.Contains(number))
                    uniques.Add(number);
            }

            Console.WriteLine("");
            foreach (var num in uniques)
                Console.WriteLine(num);*/

            Console.WriteLine("");
            foreach (var num in GetUniqueNumbers(numbers))
                Console.WriteLine(num);


        }
        public static List<int> GetUniqueNumbers(List<int>numbers)
        {
            var uniques = new List<int>();

            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                    uniques.Add(number);
            }
            return uniques;

        }
    }
}
