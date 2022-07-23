using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.BrandBanner
{
    public class BrandBannerDTO
    {
        public int brandId { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public bool isPublished { get; set; }
        public string imageUrl { get; set; }
        public IList<BrandBannerBannerDTO> brandBanners { get; set; }
        public bool showDetails { get; set; } = false;
    }
}
