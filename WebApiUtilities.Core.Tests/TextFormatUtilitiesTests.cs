using NUnit.Framework;
using WebApiUtilities.Core.Interface;

namespace WebApiUtilities.Core.Tests
{
    [TestFixture]
    public class TextFormatUtilitiesTests
    {
        private ITextFormatUtilities _utils;

        [SetUp]
        public void SetUp()
        {
            _utils = new TextFormatUtilities();
        }

        [TestCase("321ewe", "321")]
        [TestCase("ewe1231", "1231")]
        [TestCase("321ewe1231", "3211231")]
        public void RemoveLetter_returns_numbers_only(string text, string expected)
        {
            var actual = _utils.RemoveLetter(text);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
