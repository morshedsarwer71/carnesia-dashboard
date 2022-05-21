using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.OMS.ReturnManagement.ReceiveReturn
{
    public class ReceiveReturnDTO
    {
        public string SKU { get; set; }
        public string ProductName { get; set; }
        public string Image { get; set; }
        public int QTY { get; set; }
        public int Received { get; set; }
        public int Damaged { get; set; }
        public int Missing { get; set; }
    }
}
