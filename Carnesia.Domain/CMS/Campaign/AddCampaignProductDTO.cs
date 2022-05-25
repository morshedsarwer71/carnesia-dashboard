using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.Campaign
{
    public class AddCampaignProductDTO
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string DiscountType { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal AfterDiscount { get; set; }
        public decimal RegularPrice { get; set; }
    }
}
