using NSubstitute;
using TheShoppingBasket.Domain;
using TheShoppingBasket.Domain.Product;
using Xunit;

namespace TheShoppingBasketTests.Domain
{
    public class ProductShould
    {
        [Fact]
        public void initialize_with_quantity_zero()
        {
            Product product = Substitute.For<Product>("dummy");
            Assert.Equal(0, product.Quantity);
        }

        [Fact]
        public void update_quantity_when_adding_more()
        {
            Product product = Substitute.For<Product>("dummy");

            product.AddQuantity(2);

            Assert.Equal(2, product.Quantity);
        }

        [Fact]
        public void cost_price_times_quantity()
        {
            Product product = Substitute.For<Product>("dummy");
            product.Price.Returns(new Money(1.0m));

            product.AddQuantity(2);

            Assert.Equal(product.Price * 2, product.Cost());
        }

        [Fact]
        public void equal_to_another_product_when_name_is_same()
        {
            Product product = Substitute.For<Product>("dummy");
            Product another = Substitute.For<Product>("dummy");

            Assert.True(product.Equals(another));
        }
    }
}