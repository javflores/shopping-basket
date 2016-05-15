using TheShoppingBasket.Domain.Product;
using TheShoppingBasket.Services;
using Xunit;

namespace TheShoppingBasketTests
{
    public class ProductCatalogueShould
    {
        [Theory]
        [InlineData("butter")]
        [InlineData("milk")]
        [InlineData("bread")]
        [InlineData("not-in-catalogue")]
        public void provide_cost_of_given_product(string productName)
        {
            var productCatalogue = new ProductCatalogue();

            Product productFromCatalogue = productCatalogue.Get(productName);

            Assert.Equal(productName, productFromCatalogue);
        }
    }
}