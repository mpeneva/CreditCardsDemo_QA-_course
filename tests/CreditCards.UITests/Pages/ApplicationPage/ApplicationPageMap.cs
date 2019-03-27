namespace CreditCards.UITests.Pages.ApplicationPage
{
    using OpenQA.Selenium;

    public partial class ApplicationPage
    {
        private IWebElement FirstName => Driver.FindElement(By.Name("FirstName"));
                
        private IWebElement LastName => Driver.FindElement(By.Name("LastName"));

        private IWebElement FrequentFlyerNumber => Driver.FindElement(By.Id("FrequentFlyerNumber"));

        private IWebElement Age => Driver.FindElement(By.Id("Age"));

        private IWebElement GrossAnnualIncome => Driver.FindElement(By.Id("GrossAnnualIncome"));

        private IWebElement ApplyButton => Driver.FindElement(By.Id("submitApplication"));

        private IWebElement FirstError => Driver.FindElement(By.CssSelector(".validation-summary-errors ul > li"));
    }
}
