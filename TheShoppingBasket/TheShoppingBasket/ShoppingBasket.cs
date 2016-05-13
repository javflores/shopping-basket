using System.Collections.Generic;
using System.Linq;

namespace TheShoppingBasket
{
    internal class ShoppingBasket : IShoppingBasket
    {
        private Products _products = new Products();

        public ShoppingBasket()
        {
            new ProductCatalogue();
        }

        public void Add(Product product, Quantity quantity)
        {
            _products.Add(product);
        }

        public Money Total()
        {
            return _products.Cost();
        }
    }
}