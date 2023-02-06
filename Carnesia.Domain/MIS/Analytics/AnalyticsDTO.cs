using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.MIS.Analytics
{
    public class AnalyticsDTO
    {
        public List<AnalyticsDetailsDTO> cmsRevenue { get; set; }
        public List<AnalyticsDetailsDTO> posRevenue { get; set; }
    }

    public class AnalyticsDetailsDTO
    {
        public string buisnessUnit { get; set; }
        public int numberOfTransaction { get; set; }
        public int itemTotal { get; set; }
        public int qtyTotal { get; set; }
        public int storeId { get; set; }
        public decimal revenueTotal { get; set; }
        public decimal shippingDiscount { get; set; }
        public decimal productDiscount { get; set; }
        public decimal totalDiscount { get; set; }
        public decimal afterDiscount { get; set; }
        public decimal cost { get; set; }
        public decimal cancellationAmount { get; set; }
        public decimal grosProfit { get; set; }
        public string date { get; set; }
        public DateTime salesDate { get; set; }
        public string platform { get; set; }
        public DateTime orderDate { get; set; }
    }
    
    public class AnalyticsFilterDTO
    {
        public DateTime? fromDate { get; set; }
        public DateTime? toDate { get; set; }
        public int storeId { get; set; }
        public int brandId { get; set; }
        public int catId { get; set; }
		public int supplierId { get; set; }
		public string sku { get; set; }
        public string productCode { get; set; }
        public string productName { get; set; }
        public int outletId { get; set; }
        public int costProfitType { get; set; }
    }
}
