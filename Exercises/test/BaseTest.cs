using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;

namespace test
{
    public class BaseTest : IDisposable
    {
        public BaseTest()
        {
            this.Driver = new ChromeDriver();
            this.Driver.Manage().Window.Maximize();
            this.Wait = new WebDriverWait(this.Driver, TimeSpan.FromSeconds(10));
            this.Builder = new Actions(this.Driver);
        }

        protected RemoteWebDriver Driver { get; private set; }

        protected WebDriverWait Wait { get; private set; }

        protected Actions Builder { get; set; }

        public void Dispose()
        {
            this.Driver.Dispose();
        }
    }
}
