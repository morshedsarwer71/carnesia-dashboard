using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.Campaign
{
    public class AddCampaignDTO
    {
        public AddCampaignDetailsDTO createCampaignDTO { get; set; }
        public List<AddCampaignProductDTO> campaignProductsDTOs { get; set; }
    }
}
