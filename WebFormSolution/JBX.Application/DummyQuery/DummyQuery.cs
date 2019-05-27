using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JBX.Reader;

namespace JBX.Application.DummyQuery
{
    public class DummyQuery : IDummyQuery
    {
        IDummyData _dummyData;
        public DummyQuery(IDummyData dummyData)
        {
            _dummyData = dummyData;
        }

        public IReadOnlyList<PlanetDto> GetPlanets()
        {
            return _dummyData.GetPlanets();
        }
    }
}
