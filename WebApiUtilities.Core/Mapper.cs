using System;
using System.Collections.Generic;
using WebApiUtilities.Core.Interface;

namespace WebApiUtilities.Core
{
    public class Mapper : IMapper
    {
        private string[] first = { "a", "b" };
        private string[] second = { "c" };

        public IDictionary<MapperType, IEnumerable<string>> Map => new Dictionary<MapperType, IEnumerable<string>>
        {
            { MapperType.First, first }, { MapperType.Second, second }
        };        
    }
}