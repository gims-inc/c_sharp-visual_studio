using System;

namespace orderpizza
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                OrderPizza("pepperoni");
                OrderPizza("anchovies");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("press enter to continue...");
                Console.ReadLine();
            }
        }
        private static void OrderPizza(string topping)
        {
            if (topping != "pepperoni" && topping != "sausage")
            {
                throw new ArgumentException(
                String.Format("Unsupported pizza topping: {0}", topping));
            }
            Console.WriteLine("one {0} pizza ordered", topping);
        }
    }
}

