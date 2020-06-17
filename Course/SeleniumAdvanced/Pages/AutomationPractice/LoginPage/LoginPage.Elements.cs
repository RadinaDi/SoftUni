using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumAdvanced.Pages.AutomationPractice.LoginPage
{
    public partial class LoginPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/div[3]/div/div/div[1]/form/div/div[2]/input")]
        public IWebElement EmailField { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/div[3]/div/div/div[1]/form/div/div[3]/button")]
        public IWebElement CreateAccountButton { get; set; }
    }
}
