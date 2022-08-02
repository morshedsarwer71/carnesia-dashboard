using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.CMS.Campaign;

namespace Carnesia.Application.CMS.Services.CampaignList
{
    public interface ICampaignList
    {
        Task<List<CampaignDTO>> GetCampaigns();
        Task<CampaignDTO> GetCampaignByID(int id);
        Task Publishtoggle(int CampaignId);
        Task<List<CampaignBannerDTO>> GetCampaignBanners();
        Task<bool> AddCampaignBanner(AddCampaignBannerDTO banner);
        Task<bool> ToggleBannerPublish(int id);
        Task<bool> DeleteBanner(int id);
    }
}
