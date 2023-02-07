using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.OMS.ClosedOrder
{
	public class CustomerFeedbackDTO
	{
		public int id { get; set; }
		public string trnCode { get; set; }
		public int delivery { get; set; }
		public int packaging { get; set; }
		public int productQuality { get; set; }
		public int customerSupport { get; set; }
		public int average { get; set; }
		public string feedback { get; set; }
	}
}
