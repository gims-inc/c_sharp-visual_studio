using System;

namespace udclassDates
{
    class Program
    {
        static void Main(string[] args)
        {
            var timespan = new TimeSpan(1, 2, 3);

            var ts1 = new TimeSpan(1,0,0); //simmillar to
            var ts2 =  TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(10);
            Console.WriteLine(" start:{0} \n end:{1} \n Duration is:{2} ",start,end,(end- start));
            //
            Console.WriteLine("Minutes:" + timespan.Minutes );
            Console.WriteLine("Total Minutes:" + timespan.TotalMinutes );
            //
            Console.WriteLine(timespan+" add 15 mins:" + timespan.Add(TimeSpan.FromMinutes(15)));
            Console.WriteLine(timespan+" subtract 10 mins:" + timespan.Subtract(TimeSpan.FromMinutes(10)));
            //
            Console.WriteLine("To string:" + timespan.ToString());
            //
            Console.WriteLine("parse:" + TimeSpan.Parse("2:20:30"));

            /////////////////////////////////////////////////////
            Console.WriteLine("");

            var daytime = new DateTime(2002,8,29);
            Console.WriteLine(""+ daytime);
            //
            var now = DateTime.Now;
            Console.WriteLine("Now:" + now.Hour);
            //
            var today = DateTime.Today;
            Console.WriteLine("Today:" + today.ToString("d"));

            var kesho = now.AddDays(1);// jana  now.AddDays(-1)
            Console.WriteLine("kesho time ka hii itakuwa:" + kesho);
            //-
            Console.WriteLine("Now-long date:" + now.ToLongDateString());
            Console.WriteLine("Now-short date:" + now.ToShortDateString());
            Console.WriteLine("Now-long time:" + now.ToLongTimeString());
            Console.WriteLine("Now-sort time:" + now.ToShortTimeString());







        }
    }
}
