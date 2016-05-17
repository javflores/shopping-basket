using System.Collections.Generic;
using TheShoppingBasket.Domain.Product;

namespace TheShoppingBasket.Services
{
    public interface IProductWarehouse
    {
        Product Find(string product);
    }

    internal class ProductWarehouse : IProductWarehouse
    {
        private readonly Dictionary<string, Product> _productCatalogue;

        public ProductWarehouse()
        {
            _productCatalogue = new Dictionary<string, Product>()
            {
                ["butter"] = new Butter(),
                ["milk"] = new Milk(),
                ["bread"] = new Bread()
            };
        }

        public Product Find(string product)
        {
            if (_productCatalogue.ContainsKey(product))
            {
                return _productCatalogue[product];
            }

            return new NullProduct();
            
        }
    }
}