using TheShoppingBasket.Model;
using TheShoppingBasket.Repository;
using Xunit;

namespace TheShoppingBasketTests.Repository
{
    public class ProductCatalogueShould
    {
        [Theory]
        [InlineData("butter", 0.80)]
        [InlineData("milk", 1.15)]
        [InlineData("bread", 1.00)]
        [InlineData("not-in-catalogue", 0.00)]
        public void provide_cost_of_given_product(string productName, decimal expectedCost)
        {
            var productCatalogue = new ProductCatalogue();

            Money cost = productCatalogue.Cost(new Product(productName));

            Assert.Equal(new Money(expectedCost), cost);
        }
    }
}