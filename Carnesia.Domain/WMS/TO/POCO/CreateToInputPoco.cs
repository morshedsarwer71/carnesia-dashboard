using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.TO.POCO
{
    public class CreateToInputPoco
    {
        public string SourceWarehouse { get; set; }
        public string DestinationWarehouse { get; set; }
        public string productCode { get; set; }
        public string productName { get; set; }
        public string sku { get; set; }
        public int quantity { get; set; }
    }
}
