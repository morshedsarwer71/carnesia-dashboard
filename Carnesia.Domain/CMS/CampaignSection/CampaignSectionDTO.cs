using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.CampaignSection
{
    public class CampaignSectionDTO
    {
        public int id { get; set; }
        public int campaignId { get; set; }
        public string name { get; set; }
        public string alignment { get; set; }
        public string campaignName { get; set; }
        public bool IsPublish { get; set; }
        public IList<CampaignSectionThumbsDTO> thumbs { get; set; }
        public bool showDetails { get; set; }
    }

    public class CampaignSectionThumbsDTO
    {
        public int id { get; set; }
        public int sectionId { get; set; }
        public string name { get; set; }
        public string imageUrl { get; set; }
        public string url { get; set; }
        public string base64 { get; set; }
    }
}
