using System;

namespace TheShoppingBasket
{
    public class CommandLine
    {
        public static void Main(string[] args)
        {
            Application application = new Application(new ShoppingBasket());
            while (true)
            {
                var command = Console.ReadLine();
                application.Execute(command);
            }
        }
    }
}