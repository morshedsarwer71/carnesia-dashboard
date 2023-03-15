using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.TO.POCO
{
    public class ReStockTablePoco
    {
		public string productName { get; set; }
		public string productCode { get; set; }
		public string sourchWH { get; set; }
		public string desWH { get; set; }
		public decimal avgSalePerDay { get; set; }
		public int? suggestedQty { get; set; }
	}

    public class ReStockTableFilterPoco
    {
        public string? sku { get; set; }
        public string? condition { get; set; }
        public int conditionVal { get; set; }
        public DateTime? fromDate { get; set; }
        public DateTime? toDate { get; set; }
        public int sourceStoreId { get; set; }
        public int destinationStores { get; set; }
        public int stockSuggestion { get; set; }
    }

	public class RestockVM
	{
		public int sourceWh { get; set; }
		public int destinationWh { get; set; }
		public DateTime fromDate { get; set; }
		public DateTime toDate { get; set; }
		public string? reason { get; set; }
		public List<RestockProductPoco> products { get; set; }
	}
	public class RestockProductPoco
	{
		public decimal avgSalesPerDay { get; set; }
		public int suggestedQty { get; set; }
		public string productCode { get; set; }
	}
}
