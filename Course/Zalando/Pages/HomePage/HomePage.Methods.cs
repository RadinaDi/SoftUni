using OpenQA.Selenium;

namespace Zalando.Pages.HomePage
{
    public partial class HomePage : BasePage
    {
        public HomePage(IWebDriver driver)
            : base(driver)
        {
        }

        public void Open()
        {
            this.Driver.Navigate().GoToUrl("https://zalando.de");

            this.AcceptCookiesOkBitton.Click();
        }

        public void NavigateToLoginPage()
        {
            this.Builder
                .MoveToElement(this.LoginMenu)
                .Perform();

            this.LoginLink.Click();
        }

        public void NavigateToRegistrationPage()
        {
            this.Builder
                .MoveToElement(this.LoginMenu)
                .Perform();

            this.RegistrationLink.Click();
        }
    }
}
