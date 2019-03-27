namespace CreditCards.UITests.Pages.ApplicationPage
{
    using System;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;
    using CreditCards.UITests.Pages.ApplicationComplete;

    public partial class ApplicationPage
    {
        public IWebDriver Driver { get; }

        private const string PagePath = "apply";

        public ApplicationPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public void NavigateTo()
        {
            var root = new Uri(Driver.Url).GetLeftPart(UriPartial.Authority);

            var url = $"{root}/{PagePath}";

            Driver.Navigate().GoToUrl(url);
        }

        public string FirstErrorMessage => FirstError.Text;


        public void EnterName(string firstName, string lastName)
        {
            FirstName.SendKeys(firstName);
            LastName.SendKeys(lastName);
        }

        public void EnterFrequentFlyerNumber(string frequentFLyerNumber)
        {
            FrequentFlyerNumber.SendKeys(frequentFLyerNumber);
        }

        public void EnterAge(string age)
        {
            Age.SendKeys(age);
        }

        public void EnterGrossAnnualIncome(string income)
        {
            GrossAnnualIncome.SendKeys(income);
        }

        public ApplicationCompletePage SubmitApplication()
        {
            ApplyButton.Click();

            return new ApplicationCompletePage(Driver);
        }
    }
}

