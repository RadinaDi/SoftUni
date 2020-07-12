using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;
using System;

namespace SeleniumTests.Pages
{
    public class BasePage
    {
        public BasePage(IWebDriver driver, int timeoutSec = 3)
        {
            this.Driver = driver;
            this.Builder = new Actions(driver);
            this.JsExecutor = (IJavaScriptExecutor)driver;

            var locator = new RetryingElementLocator(driver, new TimeSpan(0, 0, timeoutSec));
            PageFactory.InitElements(this, locator);
        }

        protected IWebDriver Driver { get; private set; }

        protected Actions Builder { get; private set; }

        protected IJavaScriptExecutor JsExecutor { get; private set; }

        public IWebElement ScrollTo(IWebElement element)
        {
            this.JsExecutor.ExecuteScript("arguments[0].scrollIntoView(true);", element);
            return element;
        }
    }
}
