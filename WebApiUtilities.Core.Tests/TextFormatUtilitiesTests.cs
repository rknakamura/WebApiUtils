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

        [TestCase("ê", "e")]
        [TestCase("bê", "be")]
        [TestCase("bêbádãou", "bebadaou")]
        public void RemoveNotations(string text, string expected)
        {
            var actual = _utils.RemoveNotations(text);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase("ê!%", "ê")]
        [TestCase("bê*", "bê")]
        [TestCase("bêbádãou#@!$#$#", "bêbádãou")]
        public void RemoveSpecialSymbols(string text, string expected)
        {
            var actual = _utils.RemoveSpecialSymbols(text);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
