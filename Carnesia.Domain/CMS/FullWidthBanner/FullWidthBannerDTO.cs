using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.FullWidthBanner
{
    public class FullWidthBannerDTO
    {
        public int id { get; set; }
        public string bannerName { get; set; }
        public string url { get; set; }
        public bool isPublished { get; set; }
        public string imageFileUrl { get; set; }
        public string imageWebUrl { get; set; }
    }
}
