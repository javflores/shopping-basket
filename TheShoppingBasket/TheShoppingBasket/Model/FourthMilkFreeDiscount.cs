using System.Linq;

namespace TheShoppingBasket.Model
{
    public class FourthMilkFreeDiscount : Discount
    {
        public override Money Apply(Products products)
        {
            var discount = new Money();

            var numberOfMilks = NumberOfTimesToApplyOffer(products);
            for (int i = 0; i < numberOfMilks / 4; i++)
            {
                discount += _productCatalogue.Cost(new Product("milk"));
            }

            return discount;
        }

        private static int NumberOfTimesToApplyOffer(Products products)
        {
            return products.Count(product => product.Equals(new Product("milk")));
        }
    }
}