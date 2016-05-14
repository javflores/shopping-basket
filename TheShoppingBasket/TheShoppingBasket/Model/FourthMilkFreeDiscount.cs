using System.Linq;

namespace TheShoppingBasket.Model
{
    public class FourthMilkFreeDiscount : Discount
    {
        public override Money Apply(Products products)
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