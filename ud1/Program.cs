using System;

namespace ud1
{
    class Program
    {
        static void Main(string[] args) 
        {
            //Console.WriteLine("{0} {1}", int.MinValue, int.MaxValue);

            byte i = 1;
            int j = i;
            //Console.WriteLine(j);

            int m = 1000;
            byte n = (byte)m;
           // Console.WriteLine(n);

            var num = "1234";
            int a = Convert.ToInt32(num);
            //Console.WriteLine(num);

            try
            { byte b = Convert.ToByte(num); Console.WriteLine(num); }
            catch (Exception)
            { Console.WriteLine("Finyaa!"); }

            try
            { string str = "true"; bool b = Convert.ToBoolean(str); Console.WriteLine(b); }
            catch (Exception)
            { Console.WriteLine("FinyaaX2!"); }

           // Console.WriteLine("{0} {1} {2}",j,num,n);

            var c = 3;
            var d = 3;
            var e = 2;
            var f = 1;

           // Console.WriteLine((float)c / (float)d);
            Console.WriteLine(!(d != e)); //false

            Console.WriteLine(!(d != c));// true

            Console.WriteLine(f > e && d == e ); //false && false = false

        }
    }
}
