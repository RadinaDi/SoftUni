using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumTests.Pages.DatePickerPage
{
    public partial class DatePickerPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='app']/div/div/div[1]/div")]
        public IWebElement Header { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='datePickerMonthYearInput']")]
        public IWebElement DateField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='datePickerMonthYear']/div[2]/div[2]/div/div/div[2]/div[1]/div[1]")]
        public IWebElement CalendarTitleField { get; set; }

        [FindsBy(How = How.CssSelector, Using = "")]
        public IWebElement CalendarDayFromMonthField { get; set; }
    }
}
