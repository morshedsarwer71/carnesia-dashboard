using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.OMS.Zones
{
    public class DistrictDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public int divisionId { get; set; }
        public IList<ZoneDTO> zones { get; set; }
        public bool showDetails { get; set; } = false;
    }
}
