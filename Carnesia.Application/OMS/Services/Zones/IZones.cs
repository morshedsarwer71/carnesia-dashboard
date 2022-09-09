using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.OMS.Zones;

namespace Carnesia.Application.OMS.Services.Zones
{
    public interface IZones
    {
        Task<List<DivisionDTO>> GetDivisions();
        Task CreateDistrict(AddDistrictDTO District);
        Task CreateZone(AddZoneDTO Zone);
        Task UpdateDistrict(AddDistrictDTO District, int id);
        Task UpdateZone(AddZoneDTO Zone, int id);
        Task<List<ZoneDTO>> GetZones();
    }
}
