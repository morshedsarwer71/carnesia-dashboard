using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.Campaign
{
    public class AddCampaignProductDTO
    {
        public int productId { get; set; }
        public int stock { get; set; }
        public string campaignCode { get; set; }
        public string sku { get; set; }
        public string discType { get; set; }
        public decimal discAmount { get; set; }
        public decimal regularPrice { get; set; }
        public decimal discPrice { get; set; }
    }
}
