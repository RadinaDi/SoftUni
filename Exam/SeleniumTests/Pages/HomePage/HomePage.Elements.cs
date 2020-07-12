using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumTests.Pages.HomePage
{
    public partial class HomePage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='app']/div/div/div[2]/div/div[4]")]
        public IWebElement WidgetsSection { get; set; }
    }
}
