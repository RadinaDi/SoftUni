using SeleniumAdvanced.Pages.DemoQA.DraggablePage;
using SeleniumAdvanced.Pages.DemoQA.DroppablePage;
using SeleniumAdvanced.Pages.DemoQA.HomePage;
using SeleniumAdvanced.Pages.DemoQA.InteractionsPage;
using SeleniumAdvanced.Pages.DemoQA.ResizablePage;
using SeleniumAdvanced.Pages.DemoQA.SelectablePage;
using SeleniumAdvanced.Pages.DemoQA.SortablePage;
using Xunit;

namespace SeleniumAdvanced
{
    public class DemoQASiteShould : BaseTest
    {
        [Fact]
        public void BeAbleToDragElement()
        {
            var homePage = new HomePage(this.Driver);
            homePage.Open();
            homePage.JavaScriptClick(homePage.InteractionsSection);

            var interactionsPage = new InteractionsPage(this.Driver);
            interactionsPage.JavaScriptClick(interactionsPage.DraggableLink);

            var draggablePage = new DraggablePage(this.Driver);
            draggablePage.AssertElementDragging();
        }

        [Fact]
        public void BeAbleToDragAndDropElement()
        {
            var homePage = new HomePage(this.Driver);
            homePage.Open();
            homePage.JavaScriptClick(homePage.InteractionsSection);

            var interactionsPage = new InteractionsPage(this.Driver);
            interactionsPage.JavaScriptClick(interactionsPage.DroppableLink);

            var droppablePage = new DroppablePage(this.Driver);
            droppablePage.AssertDragAndDrop();
        }

        [Theory]
        [InlineData(-80, -80, 150, 150)]
        [InlineData(300, 100, 500, 300)]
        public void BeAbleToResizeElement(int offsetX, int offsetY, int expectedSizeWidth, int expectedSizeHeight)
        {
            var homePage = new HomePage(this.Driver);
            homePage.Open();
            homePage.JavaScriptClick(homePage.InteractionsSection);

            var interactionsPage = new InteractionsPage(this.Driver);
            interactionsPage.JavaScriptClick(interactionsPage.ResizableLink);

            var resizablePage = new ResizablePage(this.Driver);
            resizablePage.AssertsResize(offsetX, offsetY, expectedSizeWidth, expectedSizeHeight);
        }

        [Fact]

        public void BeAbleToSelectElement()
        {
            var homePage = new HomePage(this.Driver);
            homePage.Open();
            homePage.JavaScriptClick(homePage.InteractionsSection);

            var interactionsPage = new InteractionsPage(this.Driver);
            interactionsPage.JavaScriptClick(interactionsPage.SelectableLink);

            var selectablePage = new SelectablePage(this.Driver);
            selectablePage.AssertSelectColor();
        }

        [Fact]

        public void BeAbleToSelectGridElement()
        {
            var homePage = new HomePage(this.Driver);
            homePage.Open();
            homePage.JavaScriptClick(homePage.InteractionsSection);

            var interactionsPage = new InteractionsPage(this.Driver);
            interactionsPage.JavaScriptClick(interactionsPage.SelectableLink);

            var selectablePage = new SelectablePage(this.Driver);
            selectablePage.AssertSelectAndDragColor();
        }

        [Fact]

        public void BeAbleToSortElement()
        {
            var homePage = new HomePage(this.Driver);
            homePage.Open();
            homePage.JavaScriptClick(homePage.InteractionsSection);

            var interactionsPage = new InteractionsPage(this.Driver);
            interactionsPage.JavaScriptClick(interactionsPage.SortableLink);

            var sortablePage = new SortablePage(this.Driver);
            sortablePage.AssertReorderElements();
        }

        [Fact]
        public void BeAbleToSortGridElement()
        {
            var homePage = new HomePage(this.Driver);
            homePage.Open();
            homePage.JavaScriptClick(homePage.InteractionsSection);

            var interactionsPage = new InteractionsPage(this.Driver);
            interactionsPage.JavaScriptClick(interactionsPage.SortableLink);

            var sortablePage = new SortablePage(this.Driver);
            sortablePage.SortableGridTab.Click();
            sortablePage.AssertReorderGridElements();
        }
    }
}
