using Xunit;

namespace SeleniumAdvanced.Pages.DemoQA.ResizablePage
{
    public partial class ResizablePage : BasePage
    {
        public void AssertsResize(int offsetX, int offsetY, int expectedSizeWidth, int expectedSizeHeight)
        {
            this.Builder
                .MoveToElement(this.DraggableBox)
                .ClickAndHold()
                .MoveByOffset(offsetX, offsetY)
                .Perform();

            Assert.Equal(expectedSizeWidth, this.ResizableBox.Size.Width);
            Assert.Equal(expectedSizeHeight, this.ResizableBox.Size.Height);
        }
    }
}
