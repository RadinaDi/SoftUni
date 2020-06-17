using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumAdvanced.Pages.DemoQA.DraggablePage
{
    public partial class DraggablePage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div[2]/div[2]/div[1]/div/div[1]/div")]
        public IWebElement DraggableBox { get; set; }
    }
}
