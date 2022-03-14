using System;

namespace udclassRandom
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var random = new Random();

            const int pwdlength = 6;
            var tempwd = new char[pwdlength];

            for (var r = 0; r < pwdlength; r++)

                // Console.Write(random.Next(1,10));
                //Console.Write((char)random.Next(97, 122));

                tempwd[r]=(char)( 'a' + random.Next(4, 26));

            var pwd = new string(tempwd);

            Console.WriteLine(pwd);
        }
    }
}
