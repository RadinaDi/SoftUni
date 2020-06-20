using OpenQA.Selenium;
using Xunit;

namespace SeleniumBasics
{
    public class GoogleSiteShould : BaseTest
    {
        [Fact]
        public void SearchSeleniumInGoogle()
        {
            this.Driver.Navigate().GoToUrl("http://www.google.com");

            var input = this.Wait.Until(d => d.FindElement(By.XPath("/html/body/div/div[3]/form/div[2]/div[1]/div[1]/div/div[2]/input")));
            input.SendKeys("selenium");

            // Hide search suggestions drop-down
            // Otherwise the search button appears behind the drop-down and is not clickable
            this.LoseElementFocus();

            var submit = this.Wait.Until(d => d.FindElement(By.XPath("/html/body/div/div[3]/form/div[2]/div[1]/div[3]/center/input[1]")));
            submit.Click();

            var result = this.Wait.Until(d => d.FindElement(By.XPath("/html/body/div[6]/div[2]/div[9]/div[1]/div[2]/div/div[2]/div[2]/div/div/div[1]/div/div[1]/a")));
            result.Click();

            Assert.Equal("SeleniumHQ Browser Automation", this.Wait.Until(d => d.Title));
        }
    }
}
