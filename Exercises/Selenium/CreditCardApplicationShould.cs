using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using Xunit;
using Xunit.Abstractions;

namespace Selenium
{
    [Trait("Category", "Applications")]
    public class CreditCardApplicationShould
    {
        private const string HomeUrl = " ";
        private const string ApplyUrl = " ";

        private readonly ITestOutputHelper output;

        public CreditCardApplicationShould(ITestOutputHelper output)
        {
            this.output = output;
        }
        private object driver;
        private object appplyLink;

        [Fact]

        public void BeInitiatedFromHomePage_NewLowRate()
        {

            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl(HomeUrl);

                Utils.Delay();

                IWebElement applyLink = driver.FindElement(By.Name(" "));
                applyLink.Click();

                Utils.Delay();

                Assert.Equal("Credit Card Application = Credit Cards", driver.Title);
            }
        }

        [Fact]
        public void BeInitiatedFromHomePage_EasyApplication()
        {

            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl(HomeUrl);

                Utils.Delay();

                IWebElement carouselNext = driver.FindElement(By.CssSelector("[data - slide= 'next']"));
                carouselNext.Click();

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(1));
                wait.Until((d) => d.FindElement(By.LinkText(" ")));


                IWebElement applyLink = driver.FindElement(By.LinkText(" "));
                applyLink.Click();

                Utils.Delay();

                Assert.Equal("Credit Card Application = Credit Cards", driver.Title);
                Assert.Equal(ApplyUrl, driver.Url);

            }
        }

        [Fact]
        public void BeInitiatedFromHome_EasyAppplication_Prebuilt_Conditions()
        {
            using (IWebDriver driver = new ChromeDriver()) 
            { 

            driver.Navigate().GoToUrl(HomeUrl);

            Utils.Delay();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(11));
            IWebElement applyLink = wait.Until(ExpectedConditions.ElementToBeClickable(By.LinkText(" ")));

            Utils.Delay();

            Assert.Equal("Credit Card Application = Credit Cards", driver.Title);
            Assert.Equal(ApplyUrl, driver.Url);

            } 
        }
           

        [Fact]
        public void BeInitiatedFromHomePageCustomerService()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                output.WriteLine($"{DateTime.Now.ToLongTimeString()} Setting implicit wait");
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(35);

                // Func<IWebDriver, IWebElement> findEnabledAndVisible = delegate (IWebDriver d)
                //{

                //    var e = d.FindElement(By.ClassName(" "));

                //    if (e is null)
                //    {
                //        throw new NotFoundException();
                //    }
                //    if (e.Enabled && e.Displayed)
                //    {
                //        return e;
                //    }

                //    throw new NotFoundException();
                //};

                output.WriteLine($"{DateTime.Now.ToLongTimeString()} Navigating to {HomeUrl}");
                driver.Navigate().GoToUrl(HomeUrl);

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
                IWebElement applyLink = wait.Until(ExpectedConditions.ElementToBeClickable(By.ClassName(" ")));

                output.WriteLine($"{DateTime.Now.ToLongTimeString()} Found element Displayed = {applyLink.Displayed} Enabled= {applyLink.Enabled}");
                applyLink.Click();

                Utils.Delay();

                Assert.Equal("Credit Card Application = Credit Cards", driver.Title);
                Assert.Equal(ApplyUrl, driver.Url);

            }

        }

        [Fact]
        public void BeInitiatedFromHomePageRandomGreeting()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl(HomeUrl);

                Utils.Delay();

                IWebElement randomGreetingApplyLink = driver.FindElement(By.PartialLinkText(" "));
                randomGreetingApplyLink.Click();

                Utils.Delay();

                Assert.Equal("Credit Card Application = Credit Cards", driver.Title);
                Assert.Equal(ApplyUrl, driver.Url);
            }
        }

        [Fact]
        public void BeInitiatedFromHomePageRandomGreeting_Using_XPATH()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl(HomeUrl);

                Utils.Delay();

                IWebElement randomGreetingApplyLink = driver.FindElement(By.XPath(" "));
                randomGreetingApplyLink.Click();

                Utils.Delay();

                Assert.Equal("Credit Card Application = Credit Cards", driver.Title);
                Assert.Equal(ApplyUrl, driver.Url);
            }
        }

        [Fact]

        public void BeSubmittedWhenValid()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl(ApplyUrl);

                driver.FindElement(By.Id(" ")).SendKeys("");
                Utils.Delay();

                driver.FindElement(By.Id("")).SendKeys("");
                Utils.Delay();
                driver.FindElement(By.Id("FrequentFlyerNumber")).SendKeys("");
                Utils.Delay();
                driver.FindElement(By.Id("Age")).SendKeys("");
                Utils.Delay();
                driver.FindElement(By.Id("")).SendKeys("5000");
                Utils.Delay();
                IWebElement singleRadio = driver.FindElement(By.Id("Single"));
                singleRadio.Click();
                Utils.Delay();
                IWebElement businessSourceSelectElement = driver.FindElement(By.Id(""));

                SelectElement businessSource = new SelectElement(businessSourceSelectElement);
                Assert.Equal("", businessSource.SelectedOption.Text);

                foreach (IWebElement option in businessSource.Options)
                {
                    output.WriteLine($"Value: {option.GetAttribute("value")} Text:{option.Text}");
                }
                Assert.Equal(5, businessSource.Options.Count);
                businessSource.SelectByValue(" ");
                Utils.Delay();
                businessSource.SelectByText(" ");
                Utils.Delay();
                businessSource.SelectByIndex(4);

                driver.FindElement(By.Id("Term Accepted ")).Click();
                driver.FindElement(By.Id("SubmitApplication")).Click();

                driver.FindElement(By.Id("Single")).Submit();

                Assert.StartsWith("", driver.Title);
                Assert.Equal("", driver.FindElement(By.Id("")).Text);
                Assert.NotEmpty(driver.FindElement(By.Id(" ")).Text);
                Utils.Delay(5000);


            }
        }
    }
}

