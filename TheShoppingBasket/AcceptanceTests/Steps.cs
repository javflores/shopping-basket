using AcceptanceTests.Setup;
using Should;
using TechTalk.SpecFlow;

namespace AcceptanceTests
{
    [Binding]
    public class Steps
    {
        private string _total;

        [Given(@"the basket has ""(.*)"" ""(.*)""")]
        public void GivenTheBasketHas(int quantity, string product)
        {
            ShoppingBasketApplication.AddToBasket(quantity, product);
        }

        [When(@"I total the basket")]
        public void WhenITotalTheBasket()
        {
            _total = ShoppingBasketApplication.Total();
        }

        [Then(@"the total should be £(.*)")]
        public void ThenTheTotalShouldBe(decimal total)
        {
            _total.ShouldContain($"{total}");
        }
    }
}
