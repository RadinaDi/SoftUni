using Xunit;

namespace SeleniumAdvanced.Pages.DemoQA.SortablePage
{
    public partial class SortablePage : BasePage
    {
        public void AssertReorderElements()
        {
            var itemOneText = this.SortableItemOne.Text;
            var itemTwoText = this.SortableItemTwo.Text;

            this.Builder
                .MoveToElement(this.SortableItemOne)
                .ClickAndHold()
                .MoveByOffset(0, 30)
                .Release()
                .Perform();

            Assert.Equal(itemOneText, this.SortableItemTwo.Text);
            Assert.Equal(itemTwoText, this.SortableItemOne.Text);
        }

        public void AssertReorderGridElements()
        {
            var itemOneText = this.SortableGridItemOne.Text;
            var itemTwoText = this.SortableGridItemTwo.Text;

            this.Builder
                .MoveToElement(this.SortableGridItemOne)
                .ClickAndHold()
                .MoveByOffset(100, 0)
                .Release()
                .Perform();

            Assert.Equal(itemOneText, this.SortableGridItemTwo.Text);
            Assert.Equal(itemTwoText, this.SortableGridItemOne.Text);
        }
    }
}
