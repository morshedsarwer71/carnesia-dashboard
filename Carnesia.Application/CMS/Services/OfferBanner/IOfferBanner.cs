using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.CMS.OfferBanner;

namespace Carnesia.Application.CMS.Services.OfferBanner
{
    public interface IOfferBanner
    {
        Task<List<OfferBannerDTO>> GetPfferBanners(string url);
        Task<bool> CreateNewBanner(string url, AddOfferBannerDTO banner);
        Task<bool> ToggleBanner(string url, int id);
    }
}
