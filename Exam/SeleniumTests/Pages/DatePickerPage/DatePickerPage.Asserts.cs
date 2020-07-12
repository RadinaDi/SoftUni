using System;
using Xunit;

namespace SeleniumTests.Pages.DatePickerPage
{
    public partial class DatePickerPage : BasePage
    {
        public void AssertHeader()
        {
            Assert.Equal("Date Picker", this.Header.Text);
        }

        public void AssertCalendarTitle(int month)
        {
            var date = new DateTime(2020, month, 1);
            Assert.Equal($"{date.ToString("MMMM")} 2020", this.CalendarTitleField.Text);
        }

        public void AssertCorrectDayFromMonth(int day)
        {
            Assert.Equal(day.ToString(), this.CalendarDayFromMonthField.Text);
        }
    }
}
