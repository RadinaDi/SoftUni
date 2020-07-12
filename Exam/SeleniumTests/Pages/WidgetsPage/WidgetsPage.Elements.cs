using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumTests.Pages.WidgetsPage
{
    public partial class WidgetsPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div[2]/div[1]/div/div/div[4]/div/ul/li[2]")]
        public IWebElement AutoCompleteSection { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div[2]/div[1]/div/div/div[4]/div/ul/li[3]")]
        public IWebElement DatePickerSection { get; set; }
    }
}
