using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.OMS.CustomerPOS
{
	public class CustomerPOSPrintDTO
	{
		public string SKU { get; set; }
		public string ProductName { get; set; }
		public int QTY { get; set; }
		public decimal MRP { get; set; }
		public decimal SellingPrice { get; set; }
		public decimal SubTotal { get; set; }
	}
}
