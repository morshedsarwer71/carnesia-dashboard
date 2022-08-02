using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.Campaign
{
    public class CampaignBannerBannerDTO
    {
        public int id { get; set; }
        public int campaignId { get; set; }
        public string name { get; set; }
        public string bannerUrl { get; set; }
        public string url { get; set; }
        public bool isPublished { get; set; }
    }
}
