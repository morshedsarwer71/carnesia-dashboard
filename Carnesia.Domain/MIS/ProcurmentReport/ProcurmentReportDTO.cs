using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.MIS.ProcurmentReport
{
    public class ProcurmentReportDTO
    {
        public string productCode { get; set; }
        public string productName { get; set; }
        public string sku { get; set; }
        public int stock { get; set; }
        public int soldQty { get; set; }
        public int inboundedQty { get; set; }
        public decimal perdayAvgSales { get; set; }
        public decimal suggestgedQty { get; set; }
        public decimal lastPrice { get; set; }
        public decimal minPrice { get; set; }
        public decimal maxPrice { get; set; }
    }

    public class ProcurmentReportFilterDTO
    {
        public string? productName { get; set; }
        public string? sku { get; set; }
        public string? productCode { get; set; }
        public DateTime? fromDate { get; set; }
        public DateTime? toDate { get; set; }
        public int soldQty { get; set; }
        public string soldQtyCondition { get; set; } = "Greater Than";
        public int currentStock { get; set; }
        public string currentStockCondition { get; set; } = "Greater Than";
        public int catId { get; set; }
        public int brandId { get; set; }
    }

    public class ProcurmentReportPoDetailsParamDTO
    {
        public string? productCode { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
    }
	public class ProcurmentReportPoDetailsDTO
	{
		public DateTime poDate { get; set; }
		public string supplierName { get; set; }
		public decimal lastPrice { get; set; }
		public int receivedQty { get; set; }
	}
}
