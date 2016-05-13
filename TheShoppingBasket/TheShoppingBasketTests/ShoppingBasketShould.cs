using TheShoppingBasket;
using Xunit;

namespace TheShoppingBasketTests
{
    public class ShoppingBasketShould
    {
        private readonly ShoppingBasket _shoppingBasket;

        public ShoppingBasketShould()
        {
            _shoppingBasket = new ShoppingBasket();
        }

        [Fact]
        public void total_zero_when_no_product_has_been_added()
        {
            Money total = _shoppingBasket.Total();

            Assert.Equal(new Money(0.00m), total);
        }

        [Fact]
        public void total_product_cost_when_individual_product_has_been_added()
        {
            AddProduct("milk", "1");

            Money total = _shoppingBasket.Total();

            Assert.Equal(new Money(1.15m), total);
        }

        [Fact]
        public void total_cost_when_several_products_have_been_added()
        {
            AddProduct("milk", "1");
            AddProduct("butter", "1");

            Money total = _shoppingBasket.Total();

            Assert.Equal(new Money(1.95m), total);
        }

        private void AddProduct(string productName, string quantity)
        {
            _shoppingBasket.Add(new Product(productName), new Quantity(quantity));
        }
    }
}