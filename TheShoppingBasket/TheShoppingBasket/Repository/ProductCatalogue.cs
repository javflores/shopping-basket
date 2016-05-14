using System.Collections.Generic;
using TheShoppingBasket.Model;

namespace TheShoppingBasket.Repository
{
    public interface IProductCatalogue
    {
        Money Cost(Product product);
    }

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
            if (_productCatalogue.ContainsKey(product))
            {
                return _productCatalogue[product];
            }

            return new Money(0.00m);
            
        }
    }
}