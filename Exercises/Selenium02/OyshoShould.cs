using OpenQA.Selenium.Chrome;
using System.Threading;
using Xunit;

namespace Selenium02
{
    public class OyshoShould
    {
        [Fact]
        public void HaveCorrectTitle()
        {
            using (var driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("https://www.oysho.com/bg/");

                Thread.Sleep(3000);

                Assert.Equal("Trends in women fashion | Spring Summer 2020 | Oysho", driver.Title);
            }
        }

        [Fact]
        public void HaveCorrectItemTitle()
        {
            using (var driver = new ChromeDriver("C:\\Selenium"))
            {
                driver.Navigate().GoToUrl("https://www.oysho.com/bg/en/oysho-sport/view-all/capri-compression-leggings-c1010418502p102290437.html?colorId=800&typeCategory=0");

                Thread.Sleep(3000);

                Assert.Equal("Capri compression leggings", driver.FindElementById("productName").Text);
            }
        }

        [Fact]
         public void HasCorrectPrice()
        {
            using (var driver = new ChromeDriver("C:\\Selenium"))
            {
                driver.Navigate().GoToUrl("https://www.oysho.com/bg/en/oysho-sport/view-all/capri-compression-leggings-c1010418502p102290437.html?colorId=800&typeCategory=0");

                Thread.Sleep(3000);

                Assert.Equal("59,95 лв", driver.FindElementById("productPrice").Text);
            }

        }
    }
}
