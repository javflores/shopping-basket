using System;
using TheShoppingBasket.Infrastructure;
using TheShoppingBasket.Service;

namespace TheShoppingBasket
{
    public class CommandLine
    {
        public static void Main(string[] args)
        {
            Application application = new Application(new ShoppingBasket(), new Display());

            while (true)
            {
                var command = Console.ReadLine();
                application.Execute(command);
            }
        }
    }
}