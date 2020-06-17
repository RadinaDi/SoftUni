using Xunit;

namespace Zalando.Pages.LoginPage
{
    public partial class LoginPage : BasePage
    {
        public void AssertHeader()
        {
            Assert.Equal("LOG IN", this.Header.Text);
        }

        public void AssertEmailValidation(string expected)
        {
            Assert.Equal(expected, this.EmailValidation.Text);
        }

        public void AssertPasswordValidation(string expected)
        {
            Assert.Equal(expected, this.PasswordValidation.Text);
        }
    }
}
