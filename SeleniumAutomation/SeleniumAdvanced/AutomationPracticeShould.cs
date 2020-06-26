using SeleniumAdvanced.Data;
using SeleniumAdvanced.Pages.AutomationPractice.HomePage;
using SeleniumAdvanced.Pages.AutomationPractice.LoginPage;
using SeleniumAdvanced.Pages.AutomationPractice.RegistrationPage;
using Xunit;

namespace SeleniumAdvanced
{
    public class AutomationPracticeShould : BaseTest
    {
        private const string STR33 = "iiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiii";
        private const string STR65 = "iiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiii";
        private const string STR129 = "iiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiii";

        [Theory]
        [InlineData("", "You must register at least one phone number.")]
        public void ValidatePhoneNumber(string phoneNumber, string error)
        {
            var account = AccountData.NewAccount().WithPhoneNumber(phoneNumber);
            var registrationPage = this.OpenRegistrationPage(account.Email);
            registrationPage.RegisterWith(account);

            registrationPage.AssertValidationMessage(error);
        }

        [Theory]
        [InlineData("", "lastname is required.")]
        [InlineData("go6ev", "lastname is invalid.")]
        [InlineData(STR33, "lastname is too long. Maximum length: 32")]
        public void ValidateLastName(string lastName, string error)
        {
            var account = AccountData.NewAccount().WithLastName(lastName);
            var registrationPage = this.OpenRegistrationPage(account.Email);
            registrationPage.RegisterWith(account);

            registrationPage.AssertValidationMessage(error);
        }

        [Theory]
        [InlineData("", "firstname is required.")]
        [InlineData("go6o", "firstname is invalid.")]
        [InlineData(STR33, "firstname is too long. Maximum length: 32")]
        public void ValidateFirstName(string firstName, string error)
        {
            var account = AccountData.NewAccount().WithFirstName(firstName);
            var registrationPage = this.OpenRegistrationPage(account.Email);
            registrationPage.RegisterWith(account);

            registrationPage.AssertValidationMessage(error);
        }

        [Theory]
        [InlineData("", "city is required.")]
        [InlineData(STR65, "city is too long. Maximum length: 64")]
        public void ValidateCity(string city, string error)
        {
            var account = AccountData.NewAccount().WithCity(city);
            var registrationPage = this.OpenRegistrationPage(account.Email);
            registrationPage.RegisterWith(account);

            registrationPage.AssertValidationMessage(error);
        }

        [Theory]
        [InlineData("", "address1 is required.")]
        [InlineData(STR129, "address1 is too long. Maximum length: 128")]
        public void ValidateAddress(string address, string error)
        {
            var account = AccountData.NewAccount().WithAddress(address);
            var registrationPage = this.OpenRegistrationPage(account.Email);
            registrationPage.RegisterWith(account);

            registrationPage.AssertValidationMessage(error);
        }

        [Theory]
        [InlineData("", "passwd is required.")]
        [InlineData(STR33, "passwd is too long. Maximum length: 32")]
        public void ValidatePassword(string password, string error)
        {
            var account = AccountData.NewAccount().WithPassword(password);
            var registrationPage = this.OpenRegistrationPage(account.Email);
            registrationPage.RegisterWith(account);

            registrationPage.AssertValidationMessage(error);
        }

        [Theory]
        [InlineData("", "The Zip/Postal code you've entered is invalid. It must follow this format: 00000")]
        public void ValidateZip(string zip, string error)
        {
            var account = AccountData.NewAccount().WithZip(zip);
            var registrationPage = this.OpenRegistrationPage(account.Email);
            registrationPage.RegisterWith(account);

            registrationPage.AssertValidationMessage(error);
        }

        private RegistrationPage OpenRegistrationPage(string email)
        {
            var homePage = new HomePage(this.Driver);
            homePage.Open();
            homePage.SignInButton.Click();

            var loginPage = new LoginPage(this.Driver);
            loginPage.EmailField.SendKeys(email);
            loginPage.CreateAccountButton.Click();

            return new RegistrationPage(this.Driver);
        }
    }
}
