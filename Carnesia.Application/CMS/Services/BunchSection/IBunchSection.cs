using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.CMS.BunchSection;

namespace Carnesia.Application.CMS.Services.BunchSection
{
    public interface IBunchSection
    {
        Task<bool> CreateNewBunchSection(NewBunchSectionDTO bunch);
        Task<List<BunchSectionListDTO>> GetAllBunchSections();
        Task<bool> DeleteBunchSection(int id);
    }
}
