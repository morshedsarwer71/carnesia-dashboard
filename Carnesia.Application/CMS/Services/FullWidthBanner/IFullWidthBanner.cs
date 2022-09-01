using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.CMS.FullWidthBanner;

namespace Carnesia.Application.CMS.Services.FullWidthBanner
{
    public interface IFullWidthBanner
    {
        Task<List<FullWidthBannerDTO>> GetBanners();
        Task CreateBanner(CreateFullWidthBannerDTO Banner);
        Task<bool> PublishToggle(int id);
        Task DeleteBanner(int id);
    }
}
