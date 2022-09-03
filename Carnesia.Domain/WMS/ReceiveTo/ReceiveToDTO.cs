using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.ReceiveTo
{
    public class ReceiveToDTO
    {
        public string message { get; set; }
        public List<ReceiveToProductDTO>? data { get; set; }
    }

    public class ReceiveToProductDTO
	{
        public string sku { get; set; }
        public string picCode { get; set; }
        public object binName { get; set; }
        public string productCode { get; set; }
        public string productName { get; set; }
        public int sourceStock { get; set; }
        public int destinationStock { get; set; }
        public int qty { get; set; }
        public int pickedQty { get; set; }
        public int toBeScanned { get; set; }
    }
}
