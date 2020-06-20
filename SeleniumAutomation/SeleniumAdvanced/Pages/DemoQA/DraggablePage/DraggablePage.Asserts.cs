using Xunit;

namespace SeleniumAdvanced.Pages.DemoQA.DraggablePage
{
    public partial class DraggablePage : BasePage
    {
        public void AssertElementDragging()
        {
            var offsetX = 100;
            var offsetY = 100;

            var initialPositionX = this.DraggableBox.Location.X;
            var initialPositionY = this.DraggableBox.Location.Y;

            this.DragElement(this.DraggableBox, offsetX, offsetY);

            var postPositionX = this.DraggableBox.Location.X;
            var postPositionY = this.DraggableBox.Location.Y;

            Assert.Equal(postPositionX, initialPositionX + offsetX);
            Assert.Equal(postPositionY, initialPositionY + offsetY);
        }
    }
}
