using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JBX.Reader
{
    public interface IDummyData
    {
        IReadOnlyList<PlanetDto> GetPlanets();
    }
}
