using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.Dashboard.SalesReport
{
	public class SalesReportFilterDTO
	{
		public DateTime? fromDate { get; set; } = DateTime.Now;
		public DateTime? toDate { get; set; } = DateTime.Now;
		public int storeId { get; set; } = 0;
	}
}
