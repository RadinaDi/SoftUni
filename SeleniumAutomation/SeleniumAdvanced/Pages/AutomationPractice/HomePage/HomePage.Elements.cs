using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumAdvanced.Pages.AutomationPractice.HomePage
{
    public partial class HomePage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//*/nav/div[1]/a[@class='login']")]
        public IWebElement SignInButton { get; set; }
    }
}
