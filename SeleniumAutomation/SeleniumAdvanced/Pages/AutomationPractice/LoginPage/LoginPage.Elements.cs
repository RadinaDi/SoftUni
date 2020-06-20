using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumAdvanced.Pages.AutomationPractice.LoginPage
{
    public partial class LoginPage : BasePage
    {
        [FindsBy(How = How.Id, Using = "email_create")]
        public IWebElement EmailField { get; set; }

        [FindsBy(How = How.Id, Using = "SubmitCreate")]
        public IWebElement CreateAccountButton { get; set; }
    }
}
