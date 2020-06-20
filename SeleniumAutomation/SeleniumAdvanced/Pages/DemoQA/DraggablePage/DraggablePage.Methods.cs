using OpenQA.Selenium;

namespace SeleniumAdvanced.Pages.DemoQA.DraggablePage
{
    public partial class DraggablePage : BasePage
    {
        public DraggablePage(IWebDriver driver)
            : base(driver)
        {
        }

        public void DragElement(IWebElement element, int offsetX, int offsetY)
        {
            this.Builder
                .MoveToElement(element)
                .ClickAndHold()
                .MoveByOffset(offsetX, offsetY)
                .Perform();
        }
    }
}
