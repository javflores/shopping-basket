using System.Linq;

namespace TheShoppingBasket.Model
{
    public class FiftyPercentBreadDiscount : Discount
    {
        public override Money Apply(Products products)
        {
            var discount = new Money();

            if (CanApplyOffer(products))
            {
                return _productCatalogue.Cost(new Product("bread")).FiftyPercent();
            }

            return discount;
        }

        private bool CanApplyOffer(Products products)
        {
            var numberOfButter = products.Count(product => product.Equals(new Product("butter")));
            var numberOfBread = products.Count(product => product.Equals(new Product("bread")));

            return numberOfBread > 0 && numberOfButter > 1;
        }
    }
}