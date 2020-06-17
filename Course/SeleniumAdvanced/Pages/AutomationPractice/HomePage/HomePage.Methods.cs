using OpenQA.Selenium;

namespace SeleniumAdvanced.Pages.AutomationPractice.HomePage
{
    public partial class HomePage : BasePage
    {
        public HomePage(IWebDriver driver)
            : base(driver)
        {
        }

        public void Open()
        {
            this.Driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }
    }
}
