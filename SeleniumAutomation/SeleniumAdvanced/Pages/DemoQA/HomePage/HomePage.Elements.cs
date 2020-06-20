using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumAdvanced.Pages.DemoQA.HomePage
{
    public partial class HomePage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//div[@class='category-cards']/div[5]")]
        public IWebElement InteractionsSection { get; set; }
    }
}
