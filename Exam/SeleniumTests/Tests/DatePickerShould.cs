using SeleniumTests.Pages.DatePickerPage;
using SeleniumTests.Pages.HomePage;
using SeleniumTests.Pages.WidgetsPage;
using System;
using Xunit;

namespace SeleniumTests.Tests
{
    public class DatePickerShould : BaseTest
    {
        [Fact]
        public void BeOpenSuccessfully()
        {
            var datePickerPage = this.OpenDatePickerPage();
            datePickerPage.AssertHeader();
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(8)]
        [InlineData(9)]
        [InlineData(10)]
        [InlineData(11)]
        [InlineData(12)]
        public void SetValidDate(int month)
        {
            var random = new Random();
            var day = random.Next(1, 28);
            var datePickerPage = this.OpenDatePickerPage();

            datePickerPage.DateField.Clear();
            datePickerPage.DateField.SendKeys($"{month}/{day}/2020");

            datePickerPage.AssertCalendarTitle(month);
            datePickerPage.AssertCorrectDayFromMonth(day);
        }

        private DatePickerPage OpenDatePickerPage()
        {
            var homePage = new HomePage(this.Driver);
            homePage.OpenSite();
            homePage.ScrollTo(homePage.WidgetsSection);
            homePage.WidgetsSection.Click();

            var widgetsPage = new WidgetsPage(this.Driver);
            widgetsPage.ScrollTo(widgetsPage.DatePickerSection);
            widgetsPage.DatePickerSection.Click();

            return new DatePickerPage(this.Driver);
        }
    }
}
