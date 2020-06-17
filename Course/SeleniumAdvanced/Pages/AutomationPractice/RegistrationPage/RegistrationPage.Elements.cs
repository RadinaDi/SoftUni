using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace SeleniumAdvanced.Pages.AutomationPractice.RegistrationPage
{
    public partial class RegistrationPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/div[3]/div/div/form/div[2]/p[13]/input")]
        public IWebElement PhoneNumberField { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/div[3]/div/div/form/div[1]/div[3]/input")]
        public IWebElement LastNameField { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/div[3]/div/div/form/div[1]/div[2]/input")]
        public IWebElement FirstNameField { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/div[3]/div/div/form/div[1]/div[5]/input")]
        public IWebElement PasswordField { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/div[3]/div/div/form/div[2]/p[4]/input")]
        public IWebElement AddressField { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/div[3]/div/div/form/div[2]/p[6]/input")]
        public IWebElement CityField { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/div[3]/div/div/form/div[2]/p[8]/input")]
        public IWebElement ZipField { get; set; }

        public SelectElement StateField => new SelectElement(this.StateElement);

        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/div[3]/div/div/form/div[4]/button")]
        public IWebElement RegisterButton { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/div[3]/div/div/ol/li[1]")]
        public IWebElement ValidationSummary { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/div[3]/div/div/form/div[2]/p[7]/div/select")]
        private IWebElement StateElement { get; set; }
    }
}
