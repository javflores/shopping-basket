using System.Collections.Generic;

namespace TheShoppingBasket
{
    internal class ProductCatalogue : IProductCatalogue
    {
        private readonly Dictionary<Product, Money> _productCatalogue;

        public ProductCatalogue()
        {
            _productCatalogue = new Dictionary<Product, Money>()
            {
                [new Product("butter")] = new Money(0.80m),
                [new Product("milk")] = new Money(1.15m),
                [new Product("bread")] = new Money(1.00m)
            };
        }

        public Money Cost(Product product)
        {
            return _productCatalogue[product];
        }
    }
}