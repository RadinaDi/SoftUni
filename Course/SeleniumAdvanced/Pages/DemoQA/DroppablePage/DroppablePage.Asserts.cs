using Xunit;

namespace SeleniumAdvanced.Pages.DemoQA.DroppablePage
{
    public partial class DroppablePage : BasePage
    {
        public void AssertDragAndDrop()
        {
            var colorBefore = this.DroppableBox.GetCssValue("background-color");

            this.Builder
                .DragAndDrop(this.DraggableBox, this.DroppableBox)
                .Perform();

            var colorAfter = this.DroppableBox.GetCssValue("background-color");

            Assert.NotEqual(colorAfter, colorBefore);
        }
    }
}
