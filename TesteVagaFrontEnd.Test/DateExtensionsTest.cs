using NUnit.Framework;
using TesteVagaFrontEnd.Models;

namespace TesteVagaFrontEnd.Test
{
    [TestFixture]
    public class DateExtensionsTest
    {
        [Test]
        public void ChangeDate_AddOneMinute_ReturnDateWithOneMinuteMore()
        {
            var extension = new DateExtensions();

            var result = extension.ChangeDate("01/03/2010 23:00", '+', 1);

            Assert.AreEqual("01/03/2010 23:01", result);
        }

        [Test]
        public void ChangeDate_AddTenMinute_ReturnDateWithTenMinuteMore()
        {
            var extension = new DateExtensions();

            var result = extension.ChangeDate("01/03/2010 23:00", '+', 10);

            Assert.AreEqual("01/03/2010 23:10", result);
        }

        [Test]
        public void ChangeDate_AddOneHour_ReturnDateWithOneHourMore()
        {
            var extension = new DateExtensions();

            var result = extension.ChangeDate("01/03/2010 22:00", '+', 60);

            Assert.AreEqual("01/03/2010 23:00", result);
        }

        [Test]
        public void ChangeDate_AddOneHour_ReturnDateWithOneDayMore()
        {
            var extension = new DateExtensions();

            var result = extension.ChangeDate("01/03/2010 23:00", '+', 60);

            Assert.AreEqual("02/03/2010 00:00", result);
        }

        [Test]
        public void ChangeDate_AddTwoHour_ReturnDateWithOneDayMore()
        {
            var extension = new DateExtensions();

            var result = extension.ChangeDate("01/03/2010 23:00", '+', 120);

            Assert.AreEqual("02/03/2010 01:00", result);
        }

        [Test]
        public void ChangeDate_AddOneDay_ReturnDateWithOneDayMore()
        {
            var extension = new DateExtensions();

            var result = extension.ChangeDate("01/03/2010 23:00", '+', 1440);

            Assert.AreEqual("02/03/2010 23:00", result);
        }

        [Test]
        public void ChangeDate_AddTreeDay_ReturnDateWithTreeDayMore()
        {
            var extension = new DateExtensions();

            var result = extension.ChangeDate("01/03/2010 23:00", '+', 4320);

            Assert.AreEqual("04/03/2010 23:00", result);
        }

        [Test]
        public void ChangeDate_AddOneMouth_ReturnDateWithOneMouthMore()
        {
            var extension = new DateExtensions();

            var result = extension.ChangeDate("01/03/2010 23:00", '+', 44640);

            Assert.AreEqual("01/04/2010 23:00", result);
        }

        [Test]
        public void ChangeDate_AddFirstDayOfFebuaryAndAddThirtyDays_ReturnDateThirtyDayOfMarch()
        {
            var extension = new DateExtensions();

            var result = extension.ChangeDate("01/02/2010 23:00", '+', 43200);

            Assert.AreEqual("03/03/2010 23:00", result);
        }

        [Test]
        public void ChangeDate_AddOneYear_ReturnDateToNextYear()
        {
            var extension = new DateExtensions();

            var result = extension.ChangeDate("01/02/2010 23:00", '+', 525600);

            Assert.AreEqual("01/02/2011 23:00", result);
        }

        [Test]
        public void ChangeDate_Challenge_ReturnDateToChallenge()
        {
            var extension = new DateExtensions();

            var result = extension.ChangeDate("01/03/2010 23:00", '+', 4000);

            Assert.AreEqual("04/03/2010 17:40", result);
        }

        [Test]
        public void ChangeDate_TakingAnHour_ReturnDateOneHourLess()
        {
            var extension = new DateExtensions();

            var result = extension.ChangeDate("01/03/2010 23:00", '-', 60);

            Assert.AreEqual("01/03/2010 22:00", result);
        }

        [Test]
        public void ChangeDate_TakingTwoHour_ReturnDateTwoHourLess()
        {
            var extension = new DateExtensions();

            var result = extension.ChangeDate("01/03/2010 23:00", '-', 120);

            Assert.AreEqual("01/03/2010 21:00", result);
        }

        [Test]
        public void ChangeDate_TakingOneDay_ReturnDateOneDayLess()
        {
            var extension = new DateExtensions();

            var result = extension.ChangeDate("01/03/2010 23:00", '-', 1440);

            Assert.AreEqual("28/02/2010 23:00", result);
        }

        [Test]
        public void ChangeDate_TakingThreeDays_ReturnDateThreeDaysLess()
        {
            var extension = new DateExtensions();

            var result = extension.ChangeDate("01/03/2010 23:00", '-', 4320);

            Assert.AreEqual("26/02/2010 23:00", result);
        }

        [Test]
        public void ChangeDate_TakingOneMonth_ReturnDateOneMonthLess()
        {
            var extension = new DateExtensions();

            var result = extension.ChangeDate("01/03/2010 23:00", '-', 43200);

            Assert.AreEqual("30/01/2010 23:00", result);
        }

        [Test]
        public void ChangeDate_TakingOneYear_ReturnDateOneYearLess()
        {
            var extension = new DateExtensions();

            var result = extension.ChangeDate("01/03/2010 23:00", '-', 525600);

            Assert.AreEqual("01/03/2009 23:00", result);
        }

        [Test]
        public void ChangeDate_TakingTwoYear_ReturnDateTwoYearLess()
        {
            var extension = new DateExtensions();

            var result = extension.ChangeDate("01/03/2010 23:00", '-', 1051200);

            Assert.AreEqual("01/03/2008 23:00", result);
        }

        [Test]
        public void ChangeDate_TestNegativeValue_ReturnDateTwoYearLessWithNegativeValue()
        {
            var extension = new DateExtensions();

            var result = extension.ChangeDate("01/03/2010 23:00", '-', +1051200);

            Assert.AreEqual("01/03/2008 23:00", result);
        }
    }
}
