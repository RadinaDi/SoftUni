using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Text.RegularExpressions;
using Xunit;

namespace Selenium.HnM
{
    [Trait("Category", "Shop")]
    public class HnMShould
    {
        [Theory]
        [ClassData(typeof(HnMData))]
        public void CheckIfItemIsAvailable(string itemUrl)
        {
            Regex regex = new Regex(@"https://www2\.hm\.com/bg_bg/productpage\.([\d]+)\.html");
            var productId = regex.Match(itemUrl).Groups[1].Value;

            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl(itemUrl);

                Utils.Delay();

                Assert.Throws<NoSuchElementException>(() => driver.FindElement(By.CssSelector($"ul.picker-list li.out-of-stock[data-code=\"{productId}009\"]")));
            }
        }
    }
}
