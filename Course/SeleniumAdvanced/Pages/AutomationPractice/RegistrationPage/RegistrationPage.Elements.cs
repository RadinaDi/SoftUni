using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace SeleniumAdvanced.Pages.AutomationPractice.RegistrationPage
{
    public partial class RegistrationPage : BasePage
    {
        [FindsBy(How = How.Id, Using = "phone_mobile")]
        public IWebElement PhoneNumberField { get; set; }

        [FindsBy(How = How.Id, Using = "customer_lastname")]
        public IWebElement LastNameField { get; set; }

        [FindsBy(How = How.Id, Using = "customer_firstname")]
        public IWebElement FirstNameField { get; set; }

        [FindsBy(How = How.Id, Using = "passwd")]
        public IWebElement PasswordField { get; set; }

        [FindsBy(How = How.Id, Using = "address1")]
        public IWebElement AddressField { get; set; }

        [FindsBy(How = How.Id, Using = "city")]
        public IWebElement CityField { get; set; }

        [FindsBy(How = How.Id, Using = "postcode")]
        public IWebElement ZipField { get; set; }

        public SelectElement StateField => new SelectElement(this.StateElement);

        [FindsBy(How = How.Id, Using = "submitAccount")]
        public IWebElement RegisterButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='center_column']/div/ol/li[1]")]
        public IWebElement ValidationSummary { get; set; }

        [FindsBy(How = How.Id, Using = "id_state")]
        private IWebElement StateElement { get; set; }
    }
}
