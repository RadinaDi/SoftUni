using OpenQA.Selenium;

namespace SeleniumAdvanced.Pages.DemoQA.HomePage
{
    public partial class HomePage : BasePage
    {
        public HomePage(IWebDriver driver)
            : base(driver)
        {
        }

        public void Open()
        {
            this.Driver.Navigate().GoToUrl("http://www.demoqa.com/");
        }
    }
}
