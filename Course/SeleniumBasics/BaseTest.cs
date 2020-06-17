using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;

namespace SeleniumBasics
{
    public class BaseTest : IDisposable
    {
        public BaseTest()
        {
            this.Driver = new ChromeDriver();
            this.Wait = new WebDriverWait(this.Driver, TimeSpan.FromSeconds(2));
        }

        protected RemoteWebDriver Driver { get; private set; }

        protected WebDriverWait Wait { get; private set; }

        protected void LoseElementFocus()
        {
            this.Driver.FindElement(By.TagName("html")).Click();
        }

        public void Dispose()
        {
            this.Driver.Quit();
        }
    }
}
