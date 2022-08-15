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
        public string startDate { get; set; }
        public string startTime { get; set; }
        public string endDate { get; set; }
        public string endTime { get; set; }
        public string description { get; set; }
        public string platformType { get; set; }
        public object imagePath { get; set; }
        public bool isPublish { get; set; }
        public bool isHome { get; set; }
        public string imageFileUrl { get; set; }
        public string imageWebUrl { get; set; }
        public string base64Attch { get; set; }
        public List<CampaignProductDTO> products { get; set; }
    }
}
