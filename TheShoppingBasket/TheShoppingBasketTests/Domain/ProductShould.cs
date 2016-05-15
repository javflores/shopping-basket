using TheShoppingBasket.Domain;
using TheShoppingBasket.Domain.Product;
using Xunit;

namespace TheShoppingBasketTests.Domain
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

        [Fact]
        public void have_default_cost()
        {
            Product product = new Product("dont-exist-yet");

            Assert.Equal(new Money(), product.Cost());
        }
    }
}