using Carnesia.Domain.CRM.Vouchers.StoreVoucher.CreateStoreVoucher;
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
        public List<CreateStoreVoucherStoreDTO> campaignStoresDTOs { get; set; }
    }
}
