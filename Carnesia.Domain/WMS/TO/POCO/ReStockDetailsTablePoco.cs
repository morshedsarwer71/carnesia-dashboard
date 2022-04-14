using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.TO.POCO
{
    public class ReStockDetailsTablePoco
    {
        public string DestinationWH { get; set; }
        public int Stock { get; set; }
        public int AvgSale { get; set; }
        public int TransferQTY { get; set; }
    }
}
