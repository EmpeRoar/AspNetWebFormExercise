using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JBX.Reader
{
    public class DummyData : IDummyData
    {
        public DummyData()
        {

        }

        public IReadOnlyList<PlanetDto> GetPlanets()
        {
            return new List<PlanetDto>()
            {
                new PlanetDto()
                {
                     Id = 1,
                     Name = "Earth"
                },
                new PlanetDto()
                {
                    Id = 2,
                    Name = "Mars"
                }
            };
        }
    }
}
