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
        public string SKU { get; set; }
        public int QTY { get; set; }
    }
}
