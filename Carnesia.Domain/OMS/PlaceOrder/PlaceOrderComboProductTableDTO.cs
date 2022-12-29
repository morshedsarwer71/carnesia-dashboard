using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.OMS.PlaceOrder
{
	public class PlaceOrderComboProductTableDTO
	{
		public string message { get; set; }
		public string name { get; set; }
		public string bcCode { get; set; }
		public string comboCode { get; set; }
		public string bcType { get; set; }
		public decimal price { get; set; }
		public int quantity { get; set; }
	}
}
