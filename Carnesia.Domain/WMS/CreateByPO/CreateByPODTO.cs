using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.CreateByPO
{
    public class CreateByPODTO
    {
        public string POID { get; set; }
        public string SKU { get; set; }
        public string ProductName { get; set; }
        public string BIN { get; set; }
        public int AvailableQTY { get; set; }
        public int Found { get; set; }
        public int Missing { get; set; }
    }
}
