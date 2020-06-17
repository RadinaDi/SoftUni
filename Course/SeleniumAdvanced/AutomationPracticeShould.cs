using SeleniumAdvanced.Pages.AutomationPractice.HomePage;
using SeleniumAdvanced.Pages.AutomationPractice.LoginPage;
using SeleniumAdvanced.Pages.AutomationPractice.RegistrationPage;
using Xunit;

namespace SeleniumAdvanced
{
    public class AutomationPracticeShould : BaseTest
    {
        [Theory]
        [InlineData("You must register at least one phone number.", "", "goshev", "gosho", "12345", "center", "sofia", "10000", "Alabama")]
        [InlineData("lastname is required.", "088888888", "", "gosho", "12345", "center", "sofia", "10000", "Alabama")]
        [InlineData("lastname is invalid.", "088888888", "go6ev", "gosho", "12345", "center", "sofia", "10000", "Alabama")]
        [InlineData("firstname is required.", "088888888", "goshev", "", "12345", "center", "sofia", "10000", "Alabama")]
        [InlineData("firstname is invalid.", "088888888", "goshev", "go6o", "12345", "center", "sofia", "10000", "Alabama")]
        [InlineData("city is required.", "088888888", "goshev", "gosho", "12345", "center", "", "10000", "Alabama")]
        [InlineData("The Zip/Postal code you've entered is invalid. It must follow this format: 00000", "088888888", "goshev", "gosho", "12345", "center", "Sofia", "10", "Alabama")]
        public void DisplayCorrectRegisterErrorMessage(string error, string phoneNumber, string lastname, string firstname, string pass, string address, string city, string zip, string state)
        {
            var homePage = new HomePage(this.Driver);
            homePage.Open();
            homePage.SignInButton.Click();

            var loginPage = new LoginPage(this.Driver);
            loginPage.EmailField.SendKeys("go6o@gmail.com");
            loginPage.CreateAccountButton.Click();

            var registrationPage = new RegistrationPage(this.Driver);
            registrationPage.PhoneNumberField.SendKeys(phoneNumber);
            registrationPage.LastNameField.SendKeys(lastname);
            registrationPage.FirstNameField.SendKeys(firstname);
            registrationPage.PasswordField.SendKeys(pass);
            registrationPage.AddressField.SendKeys(address);
            registrationPage.CityField.SendKeys(city);
            registrationPage.ZipField.SendKeys(zip);
            registrationPage.StateField.SelectByText(state);
            registrationPage.RegisterButton.Submit();

            registrationPage.AssertValidationMessage(error);
        }
    }
}
