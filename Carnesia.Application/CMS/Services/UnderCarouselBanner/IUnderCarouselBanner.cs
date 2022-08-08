using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.CMS.UnderCarouselBanner;

namespace Carnesia.Application.CMS.Services.UnderCarouselBanner
{
    public interface IUnderCarouselBanner
    {
        Task<List<UnderCarouselBannerDTO>> GetAllBanners();
        Task<bool> PublishToggle(int id);
        Task AddBanner(AddUnderCarouselBannerDTO Banner);
        Task DeleteBanner(int BannerId);
    }
}
