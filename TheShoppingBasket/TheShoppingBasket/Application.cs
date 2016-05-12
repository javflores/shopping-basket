using System;

namespace TheShoppingBasket
{
    public class Application
    {
        private readonly IShoppingBasket _shoppingBasket;

        public Application(IShoppingBasket shoppingBasket)
        {
            _shoppingBasket = shoppingBasket;
        }

        public void Execute(string command)
        {
            _shoppingBasket.Add("bread", 1);
        }
    }
}
