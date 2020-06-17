using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumAdvanced.Pages.DemoQA.InteractionsPage
{
    public partial class InteractionsPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div[2]/div[1]/div/div/div[5]/div/ul/li[5]")]
        public IWebElement DraggableLink { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div[2]/div[1]/div/div/div[5]/div/ul/li[4]")]
        public IWebElement DroppableLink { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div[2]/div[1]/div/div/div[5]/div/ul/li[3]")]
        public IWebElement ResizableLink { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div[2]/div[1]/div/div/div[5]/div/ul/li[2]")]
        public IWebElement SelectableLink { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div[2]/div[1]/div/div/div[5]/div/ul/li[1]")]
        public IWebElement SortableLink { get; set; }
    }
}
