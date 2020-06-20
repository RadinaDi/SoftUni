using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumAdvanced.Pages.DemoQA.DraggablePage
{
    public partial class DraggablePage : BasePage
    {
        [FindsBy(How = How.Id, Using = "dragBox")]
        public IWebElement DraggableBox { get; set; }
    }
}
