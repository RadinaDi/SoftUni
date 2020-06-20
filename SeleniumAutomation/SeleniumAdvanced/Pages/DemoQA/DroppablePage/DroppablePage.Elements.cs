using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumAdvanced.Pages.DemoQA.DroppablePage
{
    public partial class DroppablePage : BasePage
    {
        [FindsBy(How = How.Id, Using = "draggable")]
        public IWebElement DraggableBox { get; set; }

        [FindsBy(How = How.Id, Using = "droppable")]
        public IWebElement DroppableBox { get; set; }
    }
}
