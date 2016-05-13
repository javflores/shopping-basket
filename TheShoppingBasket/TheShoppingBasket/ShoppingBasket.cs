using System;

namespace TheShoppingBasket
{
    internal class ShoppingBasket : IShoppingBasket
    {
        private readonly Products _products = new Products();

        public void Add(Product product, Quantity quantity)
        {
            quantity.Do(() => _products.Add(product));
        }

        public Money Total()
        {
            return _products.Cost();
        }
    }
}