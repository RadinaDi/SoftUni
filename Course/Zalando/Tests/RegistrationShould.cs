using OpenQA.Selenium;
using Xunit;
using Zalando.Pages.HomePage;
using Zalando.Pages.RegistrationPage;

namespace Zalando.Tests
{
    public class RegistrationShould : BaseTest
    {
        [Fact]
        public void BeOpenSuccessfully()
        {
            var homePage = new HomePage(this.Driver);
            homePage.Open();
            homePage.NavigateToRegistrationPage();

            var registrationPage = new RegistrationPage(this.Driver);
            registrationPage.AssertHeader();
        }

        [Theory]
        [InlineData("This field is required", "")]
        [InlineData("Entry is too long.", "iiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiii")]
        public void ValidateFirstName(string error, string firstName)
        {
            var homePage = new HomePage(this.Driver);
            homePage.Open();
            homePage.NavigateToRegistrationPage();

            var registrationPage = new RegistrationPage(this.Driver);
            registrationPage.FirstNameField.SendKeys(firstName);
            registrationPage.RegisterButton.Click();
            registrationPage.AsserFirstNameValidationError(error);
        }

        [Theory]
        [InlineData("This field is required", "")]
        [InlineData("Entry is too long.", "iiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiii")]
        public void ValidateLastName(string error, string lastName)
        {
            var homePage = new HomePage(this.Driver);
            homePage.Open();
            homePage.NavigateToRegistrationPage();

            var registrationPage = new RegistrationPage(this.Driver);
            registrationPage.LastNameField.SendKeys(lastName);
            registrationPage.RegisterButton.Click();
            registrationPage.AssertLastNameValidationError(error);
        }

        [Theory]
        [InlineData("This field is required", "")]
        [InlineData("Please enter a valid email address (for example: your.name@domain.com)", "abv")]
        [InlineData("Entry is too long.", "iiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiii.iiiiiiiiiiiiiii@iiiiiiiiiiiiiiiiiiiiiiiiiiii.ii")]
        public void ValidateEmail(string error, string email)
        {
            var homePage = new HomePage(this.Driver);
            homePage.Open();
            homePage.NavigateToRegistrationPage();

            var registrationPage = new RegistrationPage(this.Driver);
            registrationPage.EmailField.SendKeys(email);
            registrationPage.RegisterButton.Click();
            registrationPage.AssertEmailValidationError(error);
        }

        [Fact]
        public void CheckForExistingEmail()
        {
            var homePage = new HomePage(this.Driver);
            homePage.Open();
            homePage.NavigateToRegistrationPage();

            var registrationPage = new RegistrationPage(this.Driver);
            registrationPage.FirstNameField.SendKeys("aaaa");
            registrationPage.LastNameField.SendKeys("aaaaa");
            registrationPage.EmailField.SendKeys("radina.di@gmail.com");
            registrationPage.PasswordField.SendKeys("123456");
            registrationPage.JavaScriptClick(registrationPage.TermsAndConditionsField);
            registrationPage.AssertExistingEmailValidationError();
        }

        [Theory]
        [InlineData("This field is required", "")]
        [InlineData("For security, your password needs to be at least 6 characters. Spaces don’t count.", "radi")]
        public void ValidatePassword(string error, string password)
        {
            var homePage = new HomePage(this.Driver);
            homePage.Open();
            homePage.NavigateToRegistrationPage();

            var registrationPage = new RegistrationPage(this.Driver);
            registrationPage.PasswordField.SendKeys(password);
            registrationPage.RegisterButton.Click();
            registrationPage.AssertPasswordValidationError(error);
        }

        [Fact]
        public void ValidateTermsAndConditionsAgreement()
        {
            this.NavigateToRegistrationView();

            var registerButton = this.FindElementByXPath("//form/div[7]/button");
            registerButton.Click();

            var errorElement = this.FindElementByXPath("//form/div[6]/div/div[2]/div/div/span[2]");

            Assert.Equal("This field is required", errorElement.Text);
        }

        private void NavigateToRegistrationView()
        {
            this.Driver.Navigate().GoToUrl("https://zalando.de");

            try
            {
                var acceptCookieButton = this.Wait.Until(d => d.FindElement(By.XPath("//*[@id='uc-btn-accept-banner']")));
                acceptCookieButton.Click();
            }
            catch (StaleElementReferenceException)
            {
                var acceptCookieButton = this.Wait.Until(d => d.FindElement(By.XPath("//*[@id='uc-btn-accept-banner']")));
                acceptCookieButton.Click();
            }

            var loginMenu = this.Wait.Until(d => d.FindElement(By.XPath("//*[@id='z-navicat-header-root']/header/div[2]/div/div/div/div/z-grid/z-grid-item/div/div[1]/div[3]/div/div[2]/a/span/span")));
            this.Builder
                .MoveToElement(loginMenu)
                .Perform();

            var registerLink = this.Wait.Until(d => d.FindElement(By.XPath("//*[@id='z-navicat-header-root']/header/div[2]/div/div/div/div/z-grid/z-grid-item/div/div[1]/div[3]/div/div[2]/div[1]/div/a[2]")));
            registerLink.Click();
        }
    }
}
