using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiUtilities.Core.Interface;

namespace WebApiUtilities.Core.Tests
{
    [TestFixture]
    public class MapperTests
    {
        private IMapper _mapper;

        [SetUp]
        public void Setup()
        {
            _mapper = new Mapper();
        }

        [TestCase("a")]
        [TestCase("c")]
        public void GetKeyByValue(string value)
        {
            var actual = _mapper.Map.Single(x => x.Value.Contains(value)).Key;

            Assert.That(actual, Is.EqualTo(MapperType.First));
        }
    }
}
