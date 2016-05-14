using System.Linq;

namespace TheShoppingBasket.Model
{
    public class FiftyPercentBreadDiscount : Discount
    {
        public override Money Apply(Products products)
        {
            var discount = new Money();
            var numberOfButter = products.Count(product => product.Equals(new Product("butter")));
            for (int i = 0; i < numberOfButter / 2; i++)
            {
                discount += _productCatalogue.Cost(new Product("bread")).FiftyPercent();
            }
            return discount;
        }
    }
}