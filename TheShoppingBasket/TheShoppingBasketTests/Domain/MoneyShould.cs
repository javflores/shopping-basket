using TheShoppingBasket.Domain;
using Xunit;

namespace TheShoppingBasketTests.Domain
{
    public class MoneyShould
    {
        [Fact]
        public void equal_to_zero_when_no_amount_is_provided()
        {
            Money zeroAmount = new Money();

            Assert.Equal(new Money(0.0m), zeroAmount);
        }

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

        [Fact]
        public void sum_two_moneys()
        {
            Money first = new Money(1.0m);
            Money second = new Money(2.0m);

            Assert.Equal(new Money(3.0m), first + second);
        }

        [Fact]
        public void substract_two_moneys()
        {
            Money first = new Money(2.0m);
            Money second = new Money(1.0m);

            Assert.Equal(new Money(1.0m), first - second);
        }

        [Fact]
        public void perform_fifty_percent()
        {
            Money money = new Money(2.0m);

            Assert.Equal(new Money(1.0m), money.FiftyPercent());
        }

        [Fact]
        public void have_string_representation()
        {
            Money money = new Money(1.00m);

            Assert.Equal("£1.00", money.ToString());
        }
    }
}