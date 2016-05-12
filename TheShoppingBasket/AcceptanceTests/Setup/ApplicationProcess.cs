using TechTalk.SpecFlow;

namespace AcceptanceTests.Setup
{
    [Binding]
    class ApplicationProcess
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            ShoppingBasketApplication.Start();

        }

        [AfterScenario]
        public void AfterScenario()
        {
            ShoppingBasketApplication.Stop();
        }
    }
}