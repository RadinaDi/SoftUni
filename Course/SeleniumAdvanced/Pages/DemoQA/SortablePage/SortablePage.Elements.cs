using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumAdvanced.Pages.DemoQA.SortablePage
{
    public partial class SortablePage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div[2]/div[2]/div[1]/div/div[1]/div/div[1]")]
        public IWebElement SortableItemOne { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div[2]/div[2]/div[1]/div/div[1]/div/div[2]")]
        public IWebElement SortableItemTwo { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div[2]/div[2]/div[1]/div/div[2]/div/div/div[1]")]
        public IWebElement SortableGridItemOne { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div[2]/div[2]/div[1]/div/div[2]/div/div/div[2]")]
        public IWebElement SortableGridItemTwo { get; set; }

        [FindsBy(How = How.Id, Using = "demo-tab-grid")]
        public IWebElement SortableGridTab { get; set; }
    }
}
