using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.CampaignCarousel
{
    public class CampaignCarouselDTO
    {
        public int id { get; set; }
        public int campaignId { get; set; }
        public string name { get; set; }
        public string campaignName { get; set; }
        public string url { get; set; }
        public string imageUrl { get; set; }
        public string description { get; set; }
        public string base64 { get; set; }
        public bool isPublish { get; set; }
    }
}
