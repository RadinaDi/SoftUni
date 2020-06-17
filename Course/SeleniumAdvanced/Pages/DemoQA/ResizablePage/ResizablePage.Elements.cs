using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumAdvanced.Pages.DemoQA.ResizablePage
{
    public partial class ResizablePage : BasePage
    {
        [FindsBy(How = How.Id, Using = "resizableBoxWithRestriction")]
        public IWebElement ResizableBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='resizableBoxWithRestriction']/span")]
        public IWebElement DraggableBox { get; set; }
    }
}
