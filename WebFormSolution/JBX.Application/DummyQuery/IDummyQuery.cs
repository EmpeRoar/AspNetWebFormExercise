using JBX.Reader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JBX.Application.DummyQuery
{
    public interface IDummyQuery
    {
        IReadOnlyList<PlanetDto> GetPlanets();
    }
}
