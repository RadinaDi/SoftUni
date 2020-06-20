using Xunit;

namespace SeleniumAdvanced.Pages.DemoQA.SelectablePage
{
    public partial class SelectablePage : BasePage
    {
        public void AssertSelectColor()
        {
            var colorBefore = this.SelectableItem.GetCssValue("background-color");

            this.JsExecutor.ExecuteScript("arguments[0].click();", this.SelectableItem);

            var colorAfter = this.SelectableItem.GetCssValue("background-color");

            Assert.NotEqual(colorAfter, colorBefore);
        }

        public void AssertSelectAndDragColor()
        {
            var colorBefore = this.SelectableItem.GetCssValue("background-color");

            this.JsExecutor.ExecuteScript("arguments[0].click();", this.SelectableItem);

            this.Builder
                .MoveToElement(this.SelectableItem)
                .ClickAndHold()
                .Perform();

            var colorAfter = this.SelectableItem.GetCssValue("background-color");

            Assert.NotEqual(colorAfter, colorBefore);
        }
    }
}
