using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.TO.POCO
{
    public class ReStockTablePoco
    {
        public string SKU { get; set; }
        public string ProductName { get; set; }
        public int SourceWHStock { get; set; }
        public int AvgSale { get; set; }
        public int Quantity { get; set; }
        public string Outlate { get; set; }
        public bool ShowDetails { get; set; }
        public IList<ReStockDetailsTablePoco> Details { get; set; }
    }
}
