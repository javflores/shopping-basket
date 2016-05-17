using TheShoppingBasket.Domain.Product;
using Xunit;

namespace TheShoppingBasketTests.Domain
{
    public class ProductShould
    {
        [Fact]
        public void initialize_with_quantity_zero()
        {
            Product product = new Bread();
            Assert.Equal(0, product.Quantity);
        }

        [Fact]
        public void update_quantity_when_adding_more()
        {
            Product product = new Bread();

            product.AddQuantity(2);

            Assert.Equal(2, product.Quantity);
        }

        [Fact]
        public void cost_price_times_quantity()
        {
            Product product = new Bread();

            product.AddQuantity(2);

            Assert.Equal(product.Price * 2, product.Cost());
        }
    }
}