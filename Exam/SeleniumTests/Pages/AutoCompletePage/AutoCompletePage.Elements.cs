using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumTests.Pages.AutoCompletePage
{
    public partial class AutoCompletePage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='app']/div/div/div[1]/div")]
        public IWebElement Header { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='autoCompleteSingleInput']")]
        public IWebElement TypeSingleColorNameField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='react-select-3-option-0']")]
        public IWebElement ColorNameRedField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='react-select-3-option-1']")]
        public IWebElement ColorNameGreenField { get; set; }
    }
}
