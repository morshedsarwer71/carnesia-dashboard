using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.Campaign
{
    public class CampaignDTO
    {
        public int id { get; set; }
        public string campaignName { get; set; }
        public string campaignCode { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public string description { get; set; }
        public string platformType { get; set; }
        public object imagePath { get; set; }
        public bool isPublish { get; set; }
        public string imageFileUrl { get; set; }
        public string imageWebUrl { get; set; }
        public List<CampaignProductDTO> products { get; set; }
    }
}
