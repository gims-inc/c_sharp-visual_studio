using System;

namespace staticCon
{
    class Program
    {
        private static void Main(string[] args)
        {
            int i = 0;
            int j = 0;
            Console.WriteLine("Static Number = " + MyClass.Number);
        }
    }

    class MyClass
    {
        private static int number;
        public static int Number { get { return number; } }

        static MyClass()
        {
            Random r = new Random();
            number = r.Next();
        }
    }
}