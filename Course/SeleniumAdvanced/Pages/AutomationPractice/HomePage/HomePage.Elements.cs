using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumAdvanced.Pages.AutomationPractice.HomePage
{
    public partial class HomePage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[1]/header/div[2]/div/div/nav/div[1]/a")]
        public IWebElement SignInButton { get; set; }
    }
}
