using OpenQA.Selenium;
using SeleniumAdvanced.Model;

namespace SeleniumAdvanced.Pages.AutomationPractice.RegistrationPage
{
    public partial class RegistrationPage : BasePage
    {
        public RegistrationPage(IWebDriver driver)
            : base(driver)
        {
        }

        public void RegisterWith(Account account)
        {
            this.PhoneNumberField.SendKeys(account.PhoneNumber);
            this.LastNameField.SendKeys(account.LastName);
            this.FirstNameField.SendKeys(account.FirstName);
            this.PasswordField.SendKeys(account.Password);
            this.AddressField.SendKeys(account.Address);
            this.CityField.SendKeys(account.City);
            this.ZipField.SendKeys(account.Zip);
            this.StateField.SelectByText(account.State);
            this.RegisterButton.Submit();
        }
    }
}
