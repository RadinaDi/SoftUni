using OpenQA.Selenium;
using System.Threading;
using Xunit;

namespace test
{
    public class TestShould : BaseTest
    {
        [Fact]
        public void HaveValidRegistrationEmail()
        {
            this.Driver.Navigate().GoToUrl("https://www.massimodutti.com/bg/");

            var signin = this.Wait.Until(d => d.FindElement(By.XPath("/html/body/home-manager/home-content/div/itx-header/div/div[2]/header/div[2]/div/ul/li[2]/a/span")));
            signin.Click();

            var username = this.Wait.Until(d => d.FindElement(By.XPath("/html/body/home-manager/home-content/div/itx-header/div/div[3]/itx-user-access/div[1]/div[2]/div/itx-login/div/div[2]/form/div[1]/div[1]/input")));
            username.SendKeys("radina@gmail.com");

            var password = this.Wait.Until(d => d.FindElement(By.XPath("/html/body/home-manager/home-content/div/itx-header/div/div[3]/itx-user-access/div[1]/div[2]/div/itx-login/div/div[2]/form/div[1]/div[2]/input")));
            password.SendKeys("raDina1234");

            var submit = this.Wait.Until(d => d.FindElement(By.XPath("/html/body/home-manager/home-content/div/itx-header/div/div[3]/itx-user-access/div[1]/div[2]/div/itx-login/div/div[2]/form/div[4]/div/div[1]/button")));
            submit.Click();

            var myAccount = this.Wait.Until(d => d.FindElement(By.XPath("/html/body/home-manager/home-content/div/itx-header/div/div[2]/header/div[2]/div/ul/li[2]/a/span")));
            myAccount.Click();

            Thread.Sleep(10000);
        }
    
    }
}
