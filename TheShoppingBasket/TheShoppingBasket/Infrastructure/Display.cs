using System;
using TheShoppingBasket.Model;

namespace TheShoppingBasket.Infrastructure
{
    public interface IDisplay
    {
        void Show(Money output);
    }

    internal class Display : IDisplay
    {
        public void Show(Money output)
        {
            Console.WriteLine($"{output}");
        }
    }
}