using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;

namespace Zalando.Pages
{
    public class BasePage
    {
        public BasePage(IWebDriver driver, int timeoutSec = 3)
        {
            this.Driver = driver;
            this.Builder = new Actions(driver);
            this.JsExecutor = (IJavaScriptExecutor)driver;

            var locatior = new RetryingElementLocator(driver, new TimeSpan(0, 0, timeoutSec));
            PageFactory.InitElements(this, locatior);
        }

        protected IWebDriver Driver { get; private set; }

        protected Actions Builder { get; private set; }

        protected IJavaScriptExecutor JsExecutor { get; private set; }

        public void JavaScriptClick(IWebElement element)
        {
            this.JsExecutor.ExecuteScript("arguments[0].click();", element);
        }

        public IWebElement ScrollTo(IWebElement element)
        {
            this.JsExecutor.ExecuteScript("arguments[0].scrollIntoView(true);", element);
            return element;
        }

        public void WaitForPageLoad(int timeoutSec = 15)
        {
            WebDriverWait wait = new WebDriverWait(this.Driver, new TimeSpan(0, 0, timeoutSec));
            wait.Until(wd => this.JsExecutor.ExecuteScript("return document.readyState").ToString() == "complete");
        }
    }
}
