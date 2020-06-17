using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xunit;

namespace Selenium
{
    public class WebSiteShould
    {
        private const string homeUrl = "https://dg-14.com/";
        private const string homePageTitle = "Детска градина - ДГ №14 Карлсон - София, ж.к. Младост 2";
        private const string aboutUrl = "https://dg-14.com/za-nas/";
        private IEnumerable<char> firstProduct;

        [Fact]
        [Trait("Category", "Smoke")]
        public void NavigateToHomePage()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl(homeUrl);

                Utils.Delay();

                string pageTitle = driver.Title;

                Assert.Equal(homePageTitle, pageTitle);
                Assert.Equal(homeUrl, driver.Url);
            }
        }

        [Fact]
        [Trait("Category", "Smoke")]

        public void ReloadHomePage()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl(homeUrl);

                Utils.Delay();

                driver.Navigate().Refresh();

                Assert.Equal(homeUrl, driver.Url);
            }
        }

        [Fact]
        [Trait("Category", "Smoke")]

        public void ReloadHomePageOnBack()
        {

            using (IWebDriver driver = new ChromeDriver())
            {

                driver.Navigate().GoToUrl(homeUrl);
                IWebElement generationTokenElement =
                    driver.FindElement(By.Id("lbClose"));
                string initialToken = generationTokenElement.GetAttribute("title");

                Utils.Delay();

                driver.Navigate().GoToUrl(aboutUrl);
                Utils.Delay();

                driver.Navigate().Back();
                Utils.Delay();

                Assert.Equal(homeUrl, driver.Url);

                string reloadToken = driver.FindElement(By.Id("lbClose")).GetAttribute("title");
                Assert.Equal(initialToken, reloadToken);
            }
        }

        [Fact]
        [Trait("Category", "Smoke")]

        public void ReloadHomePageOnForward()
        {

            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl(aboutUrl);
                Utils.Delay();
                IWebElement generationTokenElement =
                driver.FindElement(By.Id("lbClose"));
                string initialToken = generationTokenElement.GetAttribute("title");

                driver.Navigate().GoToUrl(homeUrl);
                Utils.Delay();

                driver.Navigate().Back();
                Utils.Delay();

                driver.Navigate().Forward();
                Utils.Delay();

                Assert.Equal(homeUrl, driver.Url);
                string reloadToken = driver.FindElement(By.Id("lbClose")).GetAttribute("title");
                Assert.Equal(initialToken, reloadToken);

            }
        }

        [Fact]

        public void DisplayProductsAndRates()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl(aboutUrl);
                Utils.Delay();

                ReadOnlyCollection <IWebElement> tableCells = driver.FindElements(By.TagName(" "));

                Assert.Equal(" ", tableCells[0].Text);
                Assert.Equal(" ", tableCells[1].Text);

                Assert.Equal(" ", tableCells[2].Text);
                Assert.Equal(" ", tableCells[3].Text);

                Assert.Equal(" ", tableCells[4].Text);
                Assert.Equal(" ", tableCells[5].Text);
            }
        }
    }
}
