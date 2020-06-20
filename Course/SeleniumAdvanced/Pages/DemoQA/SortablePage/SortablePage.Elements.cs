using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumAdvanced.Pages.DemoQA.SortablePage
{
    public partial class SortablePage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//div[@id='demo-tabpane-list']/div/div[1]")]
        public IWebElement SortableItemOne { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='demo-tabpane-list']/div/div[2]")]
        public IWebElement SortableItemTwo { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='demo-tabpane-grid']/div/div[1]/div[1]")]
        public IWebElement SortableGridItemOne { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='demo-tabpane-grid']/div/div[1]/div[2]")]
        public IWebElement SortableGridItemTwo { get; set; }

        [FindsBy(How = How.Id, Using = "demo-tab-grid")]
        public IWebElement SortableGridTab { get; set; }
    }
}
