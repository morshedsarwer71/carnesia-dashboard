using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.Campaign
{
    public class AddCampaignDetailsDTO
    {
        public string campaignName { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public string platformType { get; set; }
        public string description { get; set; }
        public bool isPublish { get; set; } = false;
        public string base64Attch { get; set; }
    }
}
