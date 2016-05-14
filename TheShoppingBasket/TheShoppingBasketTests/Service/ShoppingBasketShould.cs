using TheShoppingBasket.Model;
using TheShoppingBasket.Service;
using Xunit;

namespace TheShoppingBasketTests.Service
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
            AddProduct("milk", 1);
            AddProduct("butter", 1);

            Money total = _shoppingBasket.Total();

            Assert.Equal(new Money(1.95m), total);
        }

        [Fact]
        public void total_cost_when_several_items_of_same_product_have_been_added()
        {
            AddProduct("bread", 3);
            AddProduct("butter", 1);

            Money total = _shoppingBasket.Total();

            Assert.Equal(new Money(3.80m), total);
        }

        [Fact]
        public void total_including_discount_of_4th_milk_free()
        {
            AddProduct("milk", 4);
            AddProduct("bread", 2);

            Money total = _shoppingBasket.Total();

            var expectedDiscountedTotal = new Money(5.45m);
            Assert.Equal(expectedDiscountedTotal, total);
        }

        [Fact]
        public void total_including_discount_of_bread_half_price()
        {
            AddProduct("butter", 2);
            AddProduct("bread", 1);

            Money total = _shoppingBasket.Total();

            var expectedDiscountedTotal = new Money(2.10m);
            Assert.Equal(expectedDiscountedTotal, total);
        }

        private void AddProduct(string productName, int quantity)
        {
            _shoppingBasket.Add(new Product(productName), new Quantity(quantity));
        }
    }
}