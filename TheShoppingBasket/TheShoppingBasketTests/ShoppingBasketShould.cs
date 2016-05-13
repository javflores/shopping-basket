using TheShoppingBasket;
using Xunit;

namespace TheShoppingBasketTests
{
    public class ShoppingBasketShould
    {
        [Fact]
        public void total_zero_when_no_product_has_been_added()
        {
            ShoppingBasket shoppingBasket = new ShoppingBasket();

            Money total = shoppingBasket.Total();

            Assert.Equal(new Money(0.00m), total);
        }
    }
}