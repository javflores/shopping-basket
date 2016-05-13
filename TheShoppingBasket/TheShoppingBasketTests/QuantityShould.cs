using TheShoppingBasket;
using Xunit;

namespace TheShoppingBasketTests
{
    public class QuantityShould
    {
        [Fact]
        public void equal_to_another_quantity()
        {
            Quantity quantity = new Quantity("1");
            Quantity anotherQuantity = new Quantity("1");

            Assert.Equal(quantity, anotherQuantity);
        }

        [Fact]
        public void not_equal_to_another_quantity()
        {
            Quantity quantity = new Quantity("1");
            Quantity anotherQuantity = new Quantity("2");

            Assert.NotEqual(quantity, anotherQuantity);
        }
    }
}