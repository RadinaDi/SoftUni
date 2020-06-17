using Xunit;
using Zalando.Pages.HomePage;
using Zalando.Pages.LoginPage;

namespace Zalando.Tests
{
    public class ZalandoLoginShould : BaseTest
    {

        [Fact]
        public void BeOpenSuccessfully()
        {
            var homePage = new HomePage(this.Driver);
            homePage.Open();
            homePage.NavigateToLoginPage();

            var loginPage = new LoginPage(this.Driver);
            loginPage.AssertHeader();
        }

        [Theory]
        [InlineData("This field is required", "")]
        [InlineData("Please enter a valid email address (for example: your.name@domain.com)", "abcdefg")]
        public void ValidateEmail(string error, string email)
        {
            var homePage = new HomePage(this.Driver);
            homePage.Open();
            homePage.NavigateToLoginPage();

            var loginPage = new LoginPage(this.Driver);
            loginPage.EmailField.SendKeys(email);
            loginPage.LoginButton.Click();
            loginPage.AssertEmailValidation(error);      
        }

        [Theory]
        [InlineData("This field is required", "")]
        public void ValidatePassword(string error, string password)
        {
            var homePage = new HomePage(this.Driver);
            homePage.Open();
            homePage.NavigateToLoginPage();

            var loginPage = new LoginPage(this.Driver);
            loginPage.PasswordField.SendKeys(password);
            loginPage.LoginButton.Click();
            loginPage.AssertPasswordValidation(error);
        }
    }
}
