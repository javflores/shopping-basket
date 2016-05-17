using System.Linq;
using TheShoppingBasket.Domain.Product;

namespace TheShoppingBasket.Domain.Discount
{
    public class FourthMilkFreeDiscount : IDiscount
    {
        public Money Apply(Products products)
        {
            var discount = new Money();
            var numberOfTimesToApplyOffer = NumberOfTimesToApplyOffer(products);
            discount += ApplyOffer(numberOfTimesToApplyOffer);

            return discount;
        }

        private int NumberOfTimesToApplyOffer(Products products)
        {
            var milk = products.SingleOrDefault(product => product.Equals(new Milk()));
            if (milk == null)
            {
                return 0;
            }

            return milk.Quantity/4;
        }

        private Money ApplyOffer(int numberOfTimesToApplyOffer)
        {
            Money discount = new Money();
            for (int i = 0; i < numberOfTimesToApplyOffer; i++)
            {
                discount += new Milk().Price;
            }
            return discount;
        }
    }
}