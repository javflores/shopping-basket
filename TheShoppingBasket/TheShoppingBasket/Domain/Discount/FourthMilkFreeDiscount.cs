using System;
using System.Linq;
using TheShoppingBasket.Domain.Product;

namespace TheShoppingBasket.Domain.Discount
{
    public class FourthMilkFreeDiscount : IDiscount
    {
        public Money Apply(Products products)
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

            Action offer = () => discount += new Milk().Cost();
            quantity.Do(offer);

            return discount;
        }

        private int NumberOfTimesToApplyOffer(Products products)
        {
            return products.Count(product => product.Equals(new Milk()))/4;
        }
    }
}