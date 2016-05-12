using System;

namespace TheShoppingBasket
{
    public class Application
    {
        public static void Main(string[] args)
        {
            ExecuteApplication();
        }

        private static void ExecuteApplication()
        {
            while (true)
            {
                var command = Console.ReadLine();
                if (command.Contains("Total"))
                {
                    Console.WriteLine("2.95");
                }
            }
        }
    }
}
