using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.CMS.GifBanner;

namespace Carnesia.Application.CMS.Services.GifBanner
{
    public interface IGifBanner
    {
        Task<List<GifBannerDTO>> GetGifBanners();
        Task AddGifBanner(AddGifBannerDTO Banner);
        Task RemoveBanner(int BannerId);
        Task<bool> ToggleGifBanner(int id);
    }
}
