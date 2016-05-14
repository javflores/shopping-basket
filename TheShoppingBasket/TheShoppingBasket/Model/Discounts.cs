using System.Collections.Generic;
using System.Linq;
using TheShoppingBasket.Repository;

namespace TheShoppingBasket.Model
{
    internal class Discounts
    {
        private readonly IList<Discount> _discounts;
        public Discounts()
        {
            _discounts = new List<Discount>
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