using System.Collections.Generic;
using TheShoppingBasket.Model;
using TheShoppingBasket.Repository;
using System.Linq;

namespace TheShoppingBasket.Service
{
    internal class Discount
    {
        private readonly IList<Product> _products;
        private readonly IProductCatalogue _productCatalogue;

        public Discount()
        {
            _products = new List<Product>();
            _productCatalogue = new ProductCatalogue();
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public Money Apply()
        {
            var discount = new Money();
            var milk = new Product("milk");

            var numberOfMilks = _products.Count(product => product.Equals(milk));
            for (int i = 0; i < numberOfMilks / 4; i++)
            {
                discount += _productCatalogue.Cost(milk);
            }

            return discount;
        }
    }
}