using TheShoppingBasket.Model;
using Xunit;

namespace TheShoppingBasketTests.Model
{
    public class FiftyPercentBreadDiscountShould
    {
        private readonly Discount fiftyPercentBreadDiscount = new FiftyPercentBreadDiscount();

        [Theory]
        [InlineData(1, 1, 0.00)]
        [InlineData(2, 1, 0.50)]
        [InlineData(3, 1, 0.50)]
        [InlineData(4, 2, 1.0)]
        public void discount_bread_at_50_percent_off(int butterQuantity, int breadQuantity, decimal expectedDiscount)
        {
            Products products = new Products();
            AddProducts(products, "butter", butterQuantity);
            AddProducts(products, "bread", breadQuantity);

            Money discount = fiftyPercentBreadDiscount.Apply(products);

            Assert.Equal(new Money(expectedDiscount), discount);
        }

        private void AddProducts(Products products, string productName, int quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                products.Add(new Product(productName));
            }
        }
    }
}