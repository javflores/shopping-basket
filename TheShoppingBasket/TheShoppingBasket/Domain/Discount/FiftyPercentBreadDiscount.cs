using System.Linq;
using TheShoppingBasket.Domain.Product;

namespace TheShoppingBasket.Domain.Discount
{
    public class FiftyPercentBreadDiscount : IDiscount
    {
        public Money Apply(Products products)
        {
            var discount = new Money();

            if (CanApplyOffer(products))
            {
                return Offer();
            }

            return discount;
        }

        private Money Offer()
        {
            return new Bread().Cost().FiftyPercent();
        }

        private bool CanApplyOffer(Products products)
        {
            var numberOfButter = products.Count(product => product.Equals(new Butter()));
            var numberOfBread = products.Count(product => product.Equals(new Bread()));

            return numberOfBread > 0 && numberOfButter > 1;
        }
    }
}