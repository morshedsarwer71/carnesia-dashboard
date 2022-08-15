using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.CMS.CreateToBag;
using Carnesia.Domain.CMS.ToBagList;

namespace Carnesia.Application.CMS.Services.ToBag
{
    public interface IToBag
    {
        Task CreateToBag(NewToBagDTO ToBag);
        Task AddSingleToBag(AddToBagDTO ToBag);
        Task<List<ToBagListSectionDTO>> GetAllToBags();
        Task DeleteToBag(int id);
        Task<bool> DeleteSection(int id);
        Task PublishToggleSection(int id);
        Task PublishToggleToBag(int id);
        Task UpdateSection(ToBagListSectionDTO Section);
        Task<bool> ToggleHomePlacement(int id);
    }
}
