using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumAdvanced.Pages.DemoQA.InteractionsPage
{
    public partial class InteractionsPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//div[@class='accordion']/div[5]/div/ul/li[@id='item-4']")]
        public IWebElement DraggableLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='accordion']/div[5]/div/ul/li[@id='item-3']")]
        public IWebElement DroppableLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='accordion']/div[5]/div/ul/li[@id='item-2']")]
        public IWebElement ResizableLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='accordion']/div[5]/div/ul/li[@id='item-1']")]
        public IWebElement SelectableLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='accordion']/div[5]/div/ul/li[@id='item-0']")]
        public IWebElement SortableLink { get; set; }
    }
}
