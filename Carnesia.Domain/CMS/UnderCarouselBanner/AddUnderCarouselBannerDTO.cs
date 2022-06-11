using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.UnderCarouselBanner
{
    public class AddUnderCarouselBannerDTO
    {
        public string bannerName { get; set; }
        public string url { get; set; }
        public string bannerPlacement { get; set; }
        public bool isPublished { get; set; } = true;
        public string base64Attch { get; set; }
    }
}
