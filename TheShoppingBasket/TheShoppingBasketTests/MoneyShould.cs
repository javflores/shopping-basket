using TheShoppingBasket;
using Xunit;

namespace TheShoppingBasketTests
{
    public class MoneyShould
    {
        [Fact]
        public void equal_to_another_money_if_amount_is_same()
        {
            Money originalMoney = new Money(1.0m);
            Money anotherMoney = new Money(1.0m);

            Assert.Equal(originalMoney, anotherMoney);
        }

        [Fact]
        public void not_equal_to_another_money_if_amount_is_different()
        {
            Money originalMoney = new Money(1.0m);
            Money anotherMoney = new Money(2.0m);

            Assert.NotEqual(originalMoney, anotherMoney);
        }
    }
}