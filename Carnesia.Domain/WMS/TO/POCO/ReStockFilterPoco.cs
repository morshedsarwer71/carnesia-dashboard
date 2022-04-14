using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.TO.POCO
{
    public class ReStockFilterPoco
    {
        public string SourceWH { get; set; }
        public string DestinationWH { get; set; }
        public string SKU { get; set; }
        public string Condition { get; set; }
        public int ConditionNumber { get; set; }
    }
}
