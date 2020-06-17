using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumAdvanced.Pages.DemoQA.HomePage
{
    public partial class HomePage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div[2]/div/div[5]")]
        public IWebElement InteractionsSection { get; set; }
    }
}
