using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.Campaign
{
    public class CampaignBannerDTO
    {
        public int id { get; set; }
        public string campaignName { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public string platformType { get; set; }
        public string imageWebUrl { get; set; }
        public bool ShowDetails { get; set; }
        public List<CampaignBannerBannerDTO> campaignBanners { get; set; }
    }
}
