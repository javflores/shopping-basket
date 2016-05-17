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
            Product product = Substitute.For<Product>();
            Assert.Equal(0, product.Quantity);
        }

        [Fact]
        public void update_quantity_when_adding_more()
        {
            Product product = Substitute.For<Product>();

            product.AddQuantity(2);

            Assert.Equal(2, product.Quantity);
        }

        [Fact]
        public void cost_price_times_quantity()
        {
            Product product = Substitute.For<Product>();
            product.Price.Returns(new Money(1.0m));

            product.AddQuantity(2);

            Assert.Equal(product.Price * 2, product.Cost());
        }
    }
}