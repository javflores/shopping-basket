using System.Collections.Generic;
using System.Linq;

namespace TheShoppingBasket
{
    public class Products
    {
        private readonly IList<Product> _products;
        private readonly ProductCatalogue _productCatalogue;

        public Products()
        {
            _products = new List<Product>();
            _productCatalogue = new ProductCatalogue();
        }
        public Money Cost()
        {
            if (!_products.Any())
            {
                return new Money(0.00m);
            }

            return _products
                .Select(product => _productCatalogue.Cost(product))
                .Aggregate((cost, nextCost) => cost + nextCost);
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }
    }
}