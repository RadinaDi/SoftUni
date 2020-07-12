using Xunit;

namespace SeleniumTests.Pages.AutoCompletePage
{
    public partial class AutoCompletePage : BasePage
    {
        public void AssertHeader()
        {
            Assert.Equal("Auto Complete", this.Header.Text);
        }

        public void AssertProposedColors()
        {
            Assert.Equal("Red", this.ColorNameRedField.Text);
            Assert.Equal("Green", this.ColorNameGreenField.Text);
        }
    }
}
