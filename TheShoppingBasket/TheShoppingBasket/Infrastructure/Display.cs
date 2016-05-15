using System;
using TheShoppingBasket.Domain;

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