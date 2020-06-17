using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Zalando.Tests
{
    public class BaseTest : IDisposable
    {
        public BaseTest()
        {
            this.Driver = new ChromeDriver();
            this.Driver.Manage().Window.Maximize();
        }

        protected IWebDriver Driver { get; private set; }

        public void Dispose()
        {
            this.Driver.Quit();
        }
    }
}
