using OpenQA.Selenium;

namespace SeleniumTests.Pages.HomePage
{
    public partial class HomePage : BasePage
    {
        public HomePage(IWebDriver driver)
            : base(driver)
        {
        }

        public void OpenSite()
        {
            this.Driver.Navigate().GoToUrl("https://demoqa.com/");
        }
    }
}
