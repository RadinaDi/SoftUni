using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Zalando.Pages.HomePage
{
    public partial class HomePage : BasePage
    {
        [FindsBy(How = How.Id, Using = "uc-btn-accept-banner")]
        public IWebElement AcceptCookiesOkBitton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='z-navicat-header-root']/header/div[2]/div/div/div/div/z-grid/z-grid-item/div/div[1]/div[3]/div/div[2]/a/span/span")]
        public IWebElement LoginMenu { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='z-navicat-header-root']/header/div[2]/div/div/div/div/z-grid/z-grid-item/div/div[1]/div[3]/div/div[2]/div[1]/div/a[1]")]
        public IWebElement LoginLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='z-navicat-header-root']/header/div[2]/div/div/div/div/z-grid/z-grid-item/div/div[1]/div[3]/div/div[2]/div[1]/div/a[2]")]
        public IWebElement RegistrationLink { get; set; }
    }
}
