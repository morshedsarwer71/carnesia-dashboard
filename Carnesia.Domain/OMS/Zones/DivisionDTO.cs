using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.OMS.Zones
{
    public class DivisionDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public IList<DistrictDTO> districts { get; set; }
        public bool showDetails { get; set; } = false;
    }
}
