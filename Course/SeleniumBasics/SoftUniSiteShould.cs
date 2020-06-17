using OpenQA.Selenium;
using Xunit;

namespace SeleniumBasics
{
    public class SoftUniSiteShould : BaseTest
    {
        [Fact]
        public void HaveCorrectHeader()
        {
            this.Driver.Navigate().GoToUrl("http://www.softuni.bg");

            var menu = this.Wait.Until(d => d.FindElement(By.XPath("/html/body/div[1]/div[1]/header/nav/div[1]/ul/li[2]/a")));
            menu.Click();

            var link = this.Wait.Until(d => d.FindElement(By.XPath("/html/body/div[1]/div[1]/header/nav/div[1]/ul/li[2]/div/div/div[2]/div[2]/div/div[1]/ul[2]/div[1]/ul/li/a")));
            link.Click();

            var header = this.Wait.Until(d => d.FindElement(By.XPath("/html/body/div[2]/header/h1")));

            Assert.Contains("QA Automation - май 2020", header.Text);
        }

    }
}
