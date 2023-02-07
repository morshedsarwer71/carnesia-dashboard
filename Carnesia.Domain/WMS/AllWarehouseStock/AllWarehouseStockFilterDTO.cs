using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.AllWarehouseStock
{
	public class AllWarehouseStockFilterDTO
	{
		public int storeId { get; set; }
		public string? productCode { get; set; }
		public string? sku { get; set; }
		public string? productName { get; set; }
		public int catId { get; set; }
		public int brandId { get; set; }
		public int vendorId { get; set; }
		public int previous { get; set; } = 0;
		public int next { get; set; } = 25;
	}
}
