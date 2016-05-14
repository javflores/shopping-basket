using System;
using System.Linq;

namespace TheShoppingBasket.Model
{
    public class FourthMilkFreeDiscount : Discount
    {
        public override Money Apply(Products products)
        {
            var numberOfTimesToApplyOffer = NumberOfTimesToApplyOffer(products);
            if (numberOfTimesToApplyOffer < 1)
            {
                return new Money();
            }

            return Offer(products);
        }

        private Money Offer(Products products)
        {
            var discount = new Money();
            var quantity = new Quantity(NumberOfTimesToApplyOffer(products));

            Action offer = () => discount += _productCatalogue.Cost(new Product("milk"));
            quantity.Do(offer);

            return discount;
        }

        private int NumberOfTimesToApplyOffer(Products products)
        {
            return products.Count(product => product.Equals(new Product("milk")))/4;
        }
    }
}