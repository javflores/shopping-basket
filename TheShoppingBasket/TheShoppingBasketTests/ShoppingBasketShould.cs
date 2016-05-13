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
            Product butter = new Product("butter");
            Quantity quantity = new Quantity("1");
            _shoppingBasket.Add(butter, quantity);

            Money total = _shoppingBasket.Total();

            Assert.Equal(new Money(0.80m), total);
        }
    }
}