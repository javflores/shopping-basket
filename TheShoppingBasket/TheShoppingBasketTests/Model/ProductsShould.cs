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
            AddProduct(productName);

            Money cost = _products.Cost();

            Assert.Equal(new Money(expectedCost), cost);
        }

        [Fact]
        public void return_cost_when_contains_several_products()
        {
            AddProduct("milk");
            AddProduct("butter");

            Money cost = _products.Cost();

            Assert.Equal(new Money(1.95m), cost);
        }

        private void AddProduct(string productName)
        {
            _products.Add(new Product(productName));
        }
    }
}