namespace CreditCards.UITests.Pages.ApplicationComplete
{
    using OpenQA.Selenium;

    public partial class ApplicationCompletePage
    {
        public IWebDriver Driver { get; }

        public ApplicationCompletePage(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}