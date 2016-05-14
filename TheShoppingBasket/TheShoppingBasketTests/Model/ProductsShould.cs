using NSubstitute;
using TheShoppingBasket.Model;
using TheShoppingBasket.Repository;
using Xunit;

namespace TheShoppingBasketTests.Model
{
    public class ProductsShould
    {
        private readonly Products _products;

        public ProductsShould()
        {
            _products = new Products();
        }

        [Fact]
        public void return_zero_cost_when_no_product_have_been_added()
        {
            Money cost = _products.Cost();

            Assert.Equal(new Money(0.0m), cost);
        }

        [Theory]
        [InlineData("butter", 0.80)]
        [InlineData("milk", 1.15)]
        [InlineData("bread", 1.00)]
        public void return_cost_of_single_product_added(string productName, decimal expectedCost)
        {
            AddProduct(productName, 1);

            Money cost = _products.Cost();

            Assert.Equal(new Money(expectedCost), cost);
        }

        [Fact]
        public void return_cost_when_contains_several_products()
        {
            AddProduct("milk", 1);
            AddProduct("butter", 1);

            Money cost = _products.Cost();

            Assert.Equal(new Money(1.95m), cost);
        }

        [Theory]
        [InlineData("milk", 4, 1.15)]
        [InlineData("milk", 8, 2.30)]
        [InlineData("milk", 12, 3.45)]
        public void discount_product(string productName, int quantity, decimal expectedDiscount)
        {
            AddProduct(productName, quantity);

            Money discount = _products.Discount();

            Assert.Equal(new Money(expectedDiscount), discount);
        }

        private void AddProduct(string productName, int quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                _products.Add(new Product(productName));
            }
        }
    }
}