using System.Collections.Generic;
using System.Linq;
using TheShoppingBasket.Domain.Product;

namespace TheShoppingBasket.Domain.Discount
{
    internal class Discounts
    {
        private readonly IList<IDiscount> _discounts;
        public Discounts()
        {
            _discounts = new List<IDiscount>
            {
                new FourthMilkFreeDiscount(),
                new FiftyPercentBreadDiscount()
            };
        }

        public Money Apply(Products products)
        {
            return _discounts
                .Select(discount => discount.Apply(products))
                .Aggregate((discount, nextDiscount) => discount + nextDiscount);
        }
    }
}