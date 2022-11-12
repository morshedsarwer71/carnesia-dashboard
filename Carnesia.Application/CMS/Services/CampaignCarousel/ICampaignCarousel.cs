using Carnesia.Domain.CMS.CampaignCarousel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Application.CMS.Services.CampaignCarousel
{
    public interface ICampaignCarousel
    {
        Task<List<CampaignCarouselDTO>> GetAllCarousels();
        Task<bool> CreateCarousel(CampaignCarouselDTO carousel);
        Task ToggleCarousel(int id);
        Task<bool> DeleteCarousel(int id);
    }
}
