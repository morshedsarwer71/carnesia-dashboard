using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.PO.ReceivePO
{
    public class ReceivePODTO
    {
        public string poCode { get; set; }
        public string vendorName { get; set; }
        public string orderDate { get; set; }
        public decimal totalValue { get; set; }
        public int totalQty { get; set; }
        public List<ReceivePOProductDTO> products { get; set; }
    }
}
