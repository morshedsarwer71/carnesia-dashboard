using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.Campaign
{
    public class AddCampaignBannerDTO
    {
        public int campaignId { get; set; }
        public string name { get; set; }
        public string url { get; set; }
        public string base64Attch { get; set; }
    }
}
