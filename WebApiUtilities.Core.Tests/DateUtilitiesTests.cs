using NUnit.Framework;
using System;
using WebApiUtilities.Core.Interface;

namespace WebApiUtilities.Core.Tests
{
    [TestFixture]
    public class DateUtilitiesTests
    {
        private IDateUtilities _utils;

        [SetUp]
        public void SetUp()
        {
            _utils = new DateUtilities();
        }


        [TestCase("10122017", "10/12/2017")]
        [TestCase("1012207", "01/01/0001")]
        public void ConvertToDate(string date, string expected)
        {
            var actual = _utils.ConvertToDate(date);

            Assert.That(actual, Is.EqualTo(DateTime.Parse(expected)));
        }


        [TestCase("10/12/2017", true)]
        [TestCase("10122017", false)]
        [TestCase("40/12/2017", false)]
        public void IsValidDate(string date, bool expected)
        {
            var actual = _utils.IsValidDate(date);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(2017, 12, 21, "21/12/2017")]
        [TestCase(2014, 02, 12, "12/02/2014")]
        public void FormatToDate(int year, int month, int day, string expected)
        {
            var actual = _utils.FormatToDate(new DateTime(year, month, day));

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
