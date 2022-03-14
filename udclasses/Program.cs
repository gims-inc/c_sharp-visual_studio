using System;

namespace udclasses
{
    public enum OS
    {
        linux =1,
        windows =2,
        mac =3,
        android =4,
        symbian =5
    }
    public class Person
    {
        public string Fname;
        public string Lname;

        public void Intro()
        {
            Console.WriteLine( "First Name: " + Fname + "\nLast Name: " + Lname);
        }
    }
   
    class Program
    {
        static void Main(string[] args)
        {

            var osType = OS.linux;
            Console.WriteLine((int)osType);
            //simmilar to
            Console.WriteLine(osType.ToString());

            var osId = 4;
            Console.WriteLine((OS)osId);

            var osName = "symbian";
            var operatingSys=(OS) Enum.Parse(typeof(OS), osName);

            Console.WriteLine((int)operatingSys);



            var Gab = new Person();

            Gab.Fname =" Gabriel";
            Gab.Lname  = "Matchisu";
            // Gab.Intro();

            //var k = Console.ReadLine();
            //var l = Console.ReadLine();

            calc calcadd = new calc();
            var ans=calcadd.Add(5,6);

            // Console.WriteLine("The Sum is:"+ ans);

            var onehundred = new int[3];
            onehundred[0] = 1;

           // Console.WriteLine("{0}{1}{2}",onehundred[0] ,onehundred[1],onehundred[2]);

            var flags = new bool[3];
            flags[0] = true;

            /*Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);*/

            var fN = "caps";
            var lN = "lock";

            var fullNm= fN +" "+lN;

            // Console.WriteLine(fullNm);

            var myFNm = string.Format("My name is {0} {1}", fN,lN);

            //Console.WriteLine(myFNm);
            var names = new string[3] { "pageup","pagdown","Insert"};
            var formattedNames = string.Join("-", names);

            // Console.WriteLine(formattedNames);
            string path_ = @"F:\DIT\stage5\503\projects
C:\wamp64\bin";

           // Console.WriteLine(path_);






        }
    }
}
