using System;

namespace udclassesLooops
{
    class Program
    {
        static void Main(string[] args)
        {

            /* while (true)
             {
                 Console.Write("Type your Name:");
                var inpt= Console.ReadLine();

                 if (string.IsNullOrWhiteSpace(inpt))
                     break;
                 Console.WriteLine(inpt);

             }*/

            //or 

            while (true)
            {
                Console.Write("Type your Name:");
                var inpt = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(inpt))
                {
                    Console.WriteLine(inpt);
                    continue;
                }
                    break;
                

            }

            
            
            var nm = "gimsinc";
            for(var n = 0; n < nm.Length; n++)
            {
                Console.Write("\n" + nm[n]);
            }

            Console.WriteLine("----------------seperator-----------");


            //simplified by foreach
            foreach (var chaR in nm)
            {
                Console.Write(chaR);
            }

           Console.WriteLine("\n--------------even numbers---------------");

           for (var i=1;i<10;i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("\t"+i);
                }
            }
            
            Console.WriteLine("\n--------------odd numbers------------------------");
            //reverse with odd num
            for (var j = 10; j > 1; j--)
            {
                if (j % 2 != 0)
                {
                    Console.Write("\t" + j);
                }
            }
        }
    }
}
