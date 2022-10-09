using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.Campaign
{
    public class CampaignProductDTO
    {
        public int id { get; set; }
        public string code { get; set; }
        public string productName { get; set; }
        public int productId { get; set; }
        public int stock { get; set; }
        public string productSku { get; set; }
        public decimal regularPrice { get; set; }
        public decimal discAmount { get; set; }
        public decimal atrDiscAmount { get; set; }
        public string discType { get; set; }
        public decimal weight { get; set; }
        public bool isCombo { get; set; }
        public int comboId { get; set; }
        public int maxOrderQty { get; set; }
    }

    public class CampaignProductUpdateDTO
    {
        public int productId { get; set; }
        public string discType { get; set; }
        public decimal discAmount { get; set; }
        public decimal regularPrice { get; set; }
        public decimal discPrice { get; set; }
        public int stock { get; set; }
        public int comboId { get; set; }
        public int maxOrderQty { get; set; }
        public bool isCombo { get; set; }
    }
}
