using NSubstitute;
using TheShoppingBasket;
using Xunit;

namespace TheShoppingBasketTests
{
    public class ApplicationShould
    {
        [Fact]
        public void add_item_to_shopping_basket_when_user_command_contains_add()
        {
            var shoppingBasket = Substitute.For<IShoppingBasket>();
            var application = new Application(shoppingBasket);

            application.Execute("Add 1 bread");

            shoppingBasket.Received().Add("bread", 1);
        }
    }
}
