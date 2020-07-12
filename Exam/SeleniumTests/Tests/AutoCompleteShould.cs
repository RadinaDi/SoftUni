using SeleniumTests.Pages.AutoCompletePage;
using SeleniumTests.Pages.HomePage;
using SeleniumTests.Pages.WidgetsPage;
using Xunit;

namespace SeleniumTests.Tests
{
    public class AutoCompleteShould : BaseTest
    {
        [Fact]
        public void BeOpenSuccessfully()
        {
            var autoCompletePage = this.OpenAutoCompletePage();
            autoCompletePage.AssertHeader();
        }

        [Fact]
        public void CheckMatchingColors()
        {
            var autoCompletePage = this.OpenAutoCompletePage();
            autoCompletePage.TypeSingleColorNameField.SendKeys("Re");
            autoCompletePage.AssertProposedColors();
        }

        private AutoCompletePage OpenAutoCompletePage()
        {
            var homePage = new HomePage(this.Driver);
            homePage.OpenSite();
            homePage.ScrollTo(homePage.WidgetsSection);
            homePage.WidgetsSection.Click();

            var widgetsPage = new WidgetsPage(this.Driver);
            widgetsPage.ScrollTo(widgetsPage.AutoCompleteSection);
            widgetsPage.AutoCompleteSection.Click();

            return new AutoCompletePage(this.Driver);
        }
    }
}
