using System;

namespace udclasses2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            bool isGoldcustomer = true;

           /* float price;
            
            if (isGoldcustomer)
            {
                price = 19.95f;
            }
            else
            {
                price = 29.95f;
            }*/

            // can be witten as 
            float price = (isGoldcustomer) ? 19.95f : 29.95f;

            //Console.WriteLine(price);


            var season = Seasons.winter;

            switch (season)

            {
                case Seasons.autumn:
                case Seasons.winter:
                    Console.WriteLine("Offer ++");// either or ->

                    break;

                case Seasons.summer:
                    Console.WriteLine("sunning");
                    break;

                default:
                    Console.WriteLine("Unknown season");
                    break;
            }

        }
    }
}
