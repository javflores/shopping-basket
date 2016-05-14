using System.Collections.Generic;
using TheShoppingBasket.Model;
using TheShoppingBasket.Repository;
using System.Linq;

namespace TheShoppingBasket.Service
{
    internal class Discount
    {
        private readonly IProductCatalogue _productCatalogue;

        public Discount()
        {
            _productCatalogue = new ProductCatalogue();
        }

        public Money Apply(Products products)
        {
            var discount = new Money();
            var milk = new Product("milk");

            var numberOfMilks = products.Count(product => product.Equals(milk));
            for (int i = 0; i < numberOfMilks / 4; i++)
            {
                discount += _productCatalogue.Cost(milk);
            }

            return discount;
        }
    }
}