using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.MIS.Analytics
{
    public class AnalyticsDTO : AnalyticsDetailsDTO
    {
        public bool showDetails { get; set; }
        public List<AnalyticsDetailsDTO> details { get; set; }
    }

    public class AnalyticsDetailsDTO
    {
        public int id { get; set; }
        public string businessUnit { get; set; }
        public int transaction { get; set; }
        public int totalItem { get; set; }
        public int totalQty { get; set; }
        public decimal totalRevenue { get; set; }
        public decimal shippingDiscount { get; set; }
        public decimal productDiscount { get; set; }
        public decimal totalDiscount { get; set; }
        public decimal afterDiscountRevenue { get; set; }
        public decimal cost { get; set; }
        public decimal grossProfit { get; set; }
    }
    
    public class AnalyticsFilterDTO
    {
        public DateTime? fromDate { get; set; }
        public DateTime? toDate { get; set; }
        public int outletId { get; set; }
        public int brandId { get; set; }
        public int category { get; set; }
        public string sku { get; set; }
        public string productCode { get; set; }
        public string productName { get; set; }
    }
}
