using OpenQA.Selenium;
using Xunit;

namespace SeleniumBasics
{
    public class AutomationPracticeSiteShould : BaseTest
    {
        [Fact]
        public void HaveValidRegistrationEmail()
        {
            this.Driver.Navigate().GoToUrl("http://automationpractice.com/index.php");

            var signin = this.Wait.Until(d => d.FindElement(By.XPath("/html/body/div/div[1]/header/div[2]/div/div/nav/div[1]/a")));
            signin.Click();

            var username = this.Wait.Until(d => d.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/div[1]/form/div/div[2]/input")));
            username.SendKeys("go6o@gmail.com");

            var submit = this.Wait.Until(d => d.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/div[1]/form/div/div[3]/button")));
            submit.Click();

            var email = this.Wait.Until(d => d.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/div[1]/div[4]/input")));

            Assert.Equal("go6o@gmail.com", email.GetAttribute("value"));
        }
    }
}
