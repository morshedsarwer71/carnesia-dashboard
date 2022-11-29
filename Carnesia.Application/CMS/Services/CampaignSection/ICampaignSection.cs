using Carnesia.Domain.CMS.CampaignSection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Application.CMS.Services.CampaignSection
{
    public interface ICampaignSection
    {
        Task<List<CampaignSectionDTO>> GetAllSections();
        Task<bool> CreateNewCampaignBunch(CampaignSectionDTO section);
        Task<CampaignSectionThumbsDTO> GetThumbById(int id);
        Task<bool> UpdateThumb(CampaignSectionThumbsDTO thumb);
    }
}
