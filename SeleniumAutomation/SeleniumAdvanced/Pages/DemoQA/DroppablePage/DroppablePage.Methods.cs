using OpenQA.Selenium;

namespace SeleniumAdvanced.Pages.DemoQA.DroppablePage
{
    public partial class DroppablePage : BasePage
    {
        public DroppablePage(IWebDriver driver)
          : base(driver)
        {
        }

        public void DragAndDropElement(IWebElement dragElement, IWebElement dropElement)
        {
            this.Builder
                .DragAndDrop(dragElement, dropElement)
                .Perform();
        }
    }
}
