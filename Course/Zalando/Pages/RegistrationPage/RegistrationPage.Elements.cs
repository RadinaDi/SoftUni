using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Zalando.Pages.RegistrationPage
{
    public partial class RegistrationPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/div[2]/div/section/div[1]/h1")]
        public IWebElement Header { get; set; }

        [FindsBy(How = How.XPath, Using = "//form/div[1]/div/div[2]/span[2]")]
        public IWebElement FirstNameField { get; set; }

        [FindsBy(How = How.XPath, Using = "//form/div[1]/div/div/input")]
        public IWebElement FirstNameErrorField { get; set; }

        [FindsBy(How = How.XPath, Using = "//form/div[2]/div/div[1]/input")]
        public IWebElement LastNameField { get; set; }

        [FindsBy(How = How.XPath, Using = "//form/div[2]/div/div[2]/span[2]")]
        public IWebElement LastNameErrorField { get; set; }

        [FindsBy(How = How.XPath, Using = "//form/div[3]/div/div[1]/input")]
        public IWebElement EmailField { get; set; }

        [FindsBy(How = How.XPath, Using = "//form/div[3]/div/div[2]/span[2]")]
        public IWebElement EmailErrorField { get; set; }

        [FindsBy(How = How.XPath, Using = "//form/div[3]/div/div[2]/span[2]")]
        public IWebElement PasswordField { get; set; }

        [FindsBy(How = How.XPath, Using = "//form/div[4]/div[1]/div[2]/span[2]")]
        public IWebElement PasswordErrorField { get; set; }

        [FindsBy(How = How.XPath, Using = "//form/div[6]/div/div[2]/div/input")]
        public IWebElement TermsAndConditionsField { get; set; }

        [FindsBy(How = How.XPath, Using = "//form/div[4]/div[1]/div/input")]
        public IWebElement RegisterButton { get; set; }
    }
}
