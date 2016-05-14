using TheShoppingBasket.Model;
using TheShoppingBasket.Service;
using Xunit;

namespace TheShoppingBasketTests.Repository
{
    public class DiscountShould
    {
        private readonly Discount _discount = new Discount();

        [Theory]
        [InlineData("milk", 4, 1.15)]
        [InlineData("milk", 5, 1.15)]
        [InlineData("milk", 8, 2.30)]
        [InlineData("milk", 12, 3.45)]
        [InlineData("milk", 14, 3.45)]
        public void discount_4th_product(string productName, int quantity, decimal expectedDiscount)
        {
            Products products = new Products();
            AddProduct(products, productName, quantity);

            Money discount = _discount.Apply(products);

            Assert.Equal(new Money(expectedDiscount), discount);
        }

        private void AddProduct(Products products, string productName, int quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                products.Add(new Product(productName));
            }
        }
    }
}