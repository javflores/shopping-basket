using System.Collections.Generic;
using TheShoppingBasket.Domain.Product;

namespace TheShoppingBasket.Services
{
    public interface IProductCatalogue
    {
        Product Get(string product);
    }

    internal class ProductCatalogue : IProductCatalogue
    {
        private readonly Dictionary<string, Product> _productCatalogue;

        public ProductCatalogue()
        {
            _productCatalogue = new Dictionary<string, Product>()
            {
                ["butter"] = new Butter(),
                ["milk"] = new Milk(),
                ["bread"] = new Bread()
            };
        }

        public Product Get(string product)
        {
            if (_productCatalogue.ContainsKey(product))
            {
                return _productCatalogue[product];
            }

            return new Product(product);
            
        }
    }
}