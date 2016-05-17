﻿using System.Linq;
using TheShoppingBasket.Domain.Product;

namespace TheShoppingBasket.Domain.Discount
{
    public class FiftyPercentBreadDiscount : IDiscount
    {
        public Money Apply(Products products)
        {
            if (CanApplyOffer(products))
            {
                return Offer();
            }

            return new Money();
        }

        private Money Offer()
        {
            return new Bread().Price.FiftyPercent();
        }

        private bool CanApplyOffer(Products products)
        {
            var butter = products.SingleOrDefault(product => product.GetType() == typeof(Butter));
            var bread = products.SingleOrDefault(product => product.GetType() == typeof(Bread));
            if (butter == null || bread == null)
            {
                return false;
            }

            return bread.Quantity > 0 && butter.Quantity > 1;
        }
    }
}