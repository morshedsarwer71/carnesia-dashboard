using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.BrandBanner
{
    public class BrandBannerBannerDTO
    {
        public int id { get; set; }
        public int brandId { get; set; }
        public string name { get; set; }
        public string bannerUrl { get; set; }
        public string url { get; set; }
    }
}
