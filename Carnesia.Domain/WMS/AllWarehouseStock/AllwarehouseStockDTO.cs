using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.AllWarehouseStock
{
    public class AllwarehouseStockDTO
    {
        public string SKU { get; set; }
        public string ProductName { get; set; }
        public decimal COGS { get; set; }
        public decimal MRP { get; set; }
        public decimal SellingPrice { get; set; }
        public int CentralWH { get; set; }
        public int DhanmondiWH { get; set; }
        public int MirpurWH { get; set; }
        public int TotalQTY { get; set; }
        public decimal TotalCOGS { get; set; }
    }
}
