using TheShoppingBasket.Model;
using Xunit;

namespace TheShoppingBasketTests.Model
{
    public class ProductShould
    {
        [Fact]
        public void equal_to_another_product_when_product_name_is_same()
        {
            Product originalProduct = new Product("bread");
            Product anotherProduct = new Product("bread");

            Assert.Equal(originalProduct, anotherProduct);
        }

        [Fact]
        public void not_equal_to_another_product_when_product_name_is_different()
        {
            Product originalProduct = new Product("bread");
            Product anotherProduct = new Product("milk");

            Assert.NotEqual(originalProduct, anotherProduct);
        }
    }
}