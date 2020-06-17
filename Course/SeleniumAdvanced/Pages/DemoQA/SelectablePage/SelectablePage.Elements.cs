using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumAdvanced.Pages.DemoQA.SelectablePage
{
    public partial class SelectablePage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div[2]/div[2]/div[1]/div/div[1]/ul/li[1]")]
        public IWebElement SelectableItem { get; set; }
    }
}
