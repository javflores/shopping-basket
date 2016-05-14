using TheShoppingBasket.Model;
using Xunit;

namespace TheShoppingBasketTests.Model
{
    public class ShoppingBasketShould
    {
        private readonly ShoppingBasket _shoppingBasket;

        public ShoppingBasketShould()
        {
            _shoppingBasket = new ShoppingBasket();
        }

        [Fact]
        public void total_cost_when_several_products_have_been_added()
        {
            AddProduct("milk", "1");
            AddProduct("butter", "1");

            Money total = _shoppingBasket.Total();

            Assert.Equal(new Money(1.95m), total);
        }

        [Fact]
        public void total_cost_when_several_items_of_same_product_have_been_added()
        {
            AddProduct("bread", "3");
            AddProduct("butter", "1");

            Money total = _shoppingBasket.Total();

            Assert.Equal(new Money(3.80m), total);
        }

        private void AddProduct(string productName, string quantity)
        {
            _shoppingBasket.Add(new Product(productName), new Quantity(quantity));
        }
    }
}