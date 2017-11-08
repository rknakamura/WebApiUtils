using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiUtilities.Core.Interface
{
    public interface IMapper
    {
        IDictionary<MapperType, IEnumerable<string>> Map { get; }
    }
}
