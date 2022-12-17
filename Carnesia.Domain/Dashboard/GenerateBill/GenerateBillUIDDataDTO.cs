using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.Dashboard.GenerateBill
{
    public class GenerateBillUIDDataDTO
    {
        public string? nameAndSKU { get; set; }
        public decimal mrp { get; set; }
        public string? productCode { get; set; }
        public string? error { get; set; }
        public string? bcType { get; set; }
        public decimal price { get; set; }
        public decimal totalPrice { get; set; }
        public int quantity { get; set; }
        public int campaignId { get; set; }
        public bool isCampaign { get; set; }
        public bool isCombo { get; set; }
        public bool showDetails { get; set; }
        public List<GenerateBillComboProductDetailsDTO>? products { get; set; }
    }

    public class GenerateBillUIDCollectionDTO
    {
        public string uid { get; set; }
        public bool isBogoCombo { get; set; }
        public string productCode { get; set; }
    }

    public class GenerateBillComboProductDTO
    {
        public string comboCode { get; set; }
        public string bcType { get; set; }
        public decimal price { get; set; }
        public int quantity { get; set; }
        public decimal totalPrice { get; set; }
        public bool isCampaign { get; set; }
        public int campaignId { get; set; }
    }
}
