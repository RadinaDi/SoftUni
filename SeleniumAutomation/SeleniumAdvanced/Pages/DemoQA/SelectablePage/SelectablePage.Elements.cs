using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumAdvanced.Pages.DemoQA.SelectablePage
{
    public partial class SelectablePage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//ul[@id='verticalListContainer']/li[1]")]
        public IWebElement SelectableItem { get; set; }
    }
}
