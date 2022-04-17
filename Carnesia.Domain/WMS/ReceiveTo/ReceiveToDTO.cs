using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.ReceiveTo
{
    public class ReceiveToDTO
    {
        public string SKU { get; set; }
        public string ProductName { get; set; }
        public int ToQTY { get; set; }
        public int ReceiveQTY { get; set; }
    }
}
