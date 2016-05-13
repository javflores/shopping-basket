using System;

namespace TheShoppingBasket
{
    internal class Display : IDisplay
    {
        public void Show(Money output)
        {
            Console.WriteLine($"{output}");
        }
    }
}