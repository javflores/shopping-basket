﻿using System.Collections.Generic;
using System.Linq;
using TheShoppingBasket.Repository;

namespace TheShoppingBasket.Model
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

        public void Add(Product product)
        {
            _products.Add(product);
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
    }
}