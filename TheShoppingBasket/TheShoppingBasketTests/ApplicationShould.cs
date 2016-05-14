using NSubstitute;
using TheShoppingBasket;
using TheShoppingBasket.Infrastructure;
using TheShoppingBasket.Model;
using Xunit;

namespace TheShoppingBasketTests
{
    public class ApplicationShould
    {
        private readonly IShoppingBasket _shoppingBasket;
        private readonly IDisplay _display;
        private readonly Application _application;

        public ApplicationShould()
        {
            _shoppingBasket = Substitute.For<IShoppingBasket>();
            _display = Substitute.For<IDisplay>();
            _application = new Application(_shoppingBasket,_display);
        }

        [Theory]
        [InlineData("Add 1 bread", "bread", "1")]
        [InlineData("Add 3 milk", "milk", "3")]
        public void add_items_to_shopping_basket_when_user_command_contains_add(string command, string productName, string quantity)
        {
            _application.Execute(command);

            Product expectedProduct = new Product(productName);
            Quantity expectedQuantity = new Quantity(quantity);
            _shoppingBasket.Received().Add(
                Arg.Is<Product>(p => p.Equals(expectedProduct)), Arg.Is<Quantity>(q => q.Equals(expectedQuantity)));
        }

        [Fact]
        public void get_total_from_shopping_basket()
        {
            _application.Execute("Total");

            _shoppingBasket.Received().Total();
        }

        [Fact]
        public void prints_total()
        {
            _shoppingBasket.Total().Returns(new Money(10.00m));

            _application.Execute("Total");

            _display.Received().Show(Arg.Is<Money>(
                output => output.Equals(new Money(10.00m))));
        }
    }
}
