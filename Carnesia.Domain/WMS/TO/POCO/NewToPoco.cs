using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.TO.POCO
{
	public class NewToPoco
	{
		public CreateStockTransferPoco createStockTransferDTO { get; set; }
		public List<CreateToProductPoco> transferProductDTOs { get; set; }
	}

	public class CreateStockTransferPoco
	{
		public int toStoreId { get; set; }
		public int fromStoreId { get; set; }
		public int totalSKUQty { get; set; }
	}
}
