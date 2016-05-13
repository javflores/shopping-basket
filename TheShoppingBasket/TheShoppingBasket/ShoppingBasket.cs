using System.Collections.Generic;

namespace TheShoppingBasket
{
    internal class ShoppingBasket : IShoppingBasket
    {
        private Money _total = new Money(0.00m);

        public void Add(Product product, Quantity quantity)
        {
            var productCatalogue = new Dictionary<Product, Money>()
            {
                [new Product("butter")] = new Money(0.80m),
                [new Product("milk")] = new Money(1.15m)
            };

            _total = productCatalogue[product];
        }

        public Money Total()
        {
            return _total;
        }
    }
}