namespace CreditCards.UITests.Pages.ApplicationComplete
{
    using OpenQA.Selenium;

    public partial class ApplicationCompletePage
    {
        private IWebElement Name => Driver.FindElement(By.Id("fullName"));
        
        private IWebElement Decision => Driver.FindElement(By.Id("decision"));

        public string FullName => Name.Text;

        public string ApplicationDecision => Decision.Text;
    }
}
