using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Zalando.Pages.LoginPage
{
    public partial class LoginPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//div[@class='reef-zds_modalContent']/div[1]/div/div/div[2]")]
        public IWebElement Header { get; set; }

        [FindsBy(How = How.Id, Using = "login.email")]
        public IWebElement EmailField { get; set; }

        [FindsBy(How = How.XPath, Using = "//form/div[1]/div/div[2]/span[2]")]
        public IWebElement EmailValidation { get; set; }

        [FindsBy(How = How.Id, Using = "login.password")]
        public IWebElement PasswordField { get; set; }

        [FindsBy(How = How.XPath, Using = "//form/div[2]/div/div[2]/span[2]")]
        public IWebElement PasswordValidation { get; set; }

        [FindsBy(How = How.XPath, Using = "//form/div[3]/button")]
        public IWebElement LoginButton { get; set; }
    }
}
