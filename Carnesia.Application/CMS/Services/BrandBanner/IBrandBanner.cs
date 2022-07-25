using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.CMS.BrandBanner;


namespace Carnesia.Application.CMS.Services.BrandBanner
{
    public interface IBrandBanner
    {
        Task<List<BrandBannerDTO>> GetBrandBanners();
        Task<bool> CreateBrandBanner(AddBrandBannerDTO banner);
        Task DeleteBanner(int id);
    }
}
