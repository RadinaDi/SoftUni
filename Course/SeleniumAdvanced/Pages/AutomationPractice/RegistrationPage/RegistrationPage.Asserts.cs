using Xunit;

namespace SeleniumAdvanced.Pages.AutomationPractice.RegistrationPage
{
    public partial class RegistrationPage : BasePage
    {
        public void AssertValidationMessage(string error)
        {
            Assert.Equal(error, this.ValidationSummary.Text);
        }
    }
}
