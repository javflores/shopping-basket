using System;
using System.Linq;
using NSubstitute;
using TheShoppingBasket.Domain;
using Xunit;

namespace TheShoppingBasketTests.Domain
{
    public class QuantityShould
    {
        [Fact]
        public void equal_to_another_quantity()
        {
            Quantity quantity = new Quantity(1);
            Quantity anotherQuantity = new Quantity(1);

            Assert.Equal(quantity, anotherQuantity);
        }

        [Fact]
        public void not_equal_to_another_quantity()
        {
            Quantity quantity = new Quantity(1);
            Quantity anotherQuantity = new Quantity(2);

            Assert.NotEqual(quantity, anotherQuantity);
        }

        [Fact]
        public void do_action_for_times_given_in_quantity()
        {
            var timesToDoAction = 3;
            Quantity quantity = new Quantity(timesToDoAction);
            Action fakeAction = Substitute.For<Action>();

            quantity.Do(fakeAction);

            Assert.Equal(timesToDoAction, fakeAction.ReceivedCalls().Count());
        }
    }
}