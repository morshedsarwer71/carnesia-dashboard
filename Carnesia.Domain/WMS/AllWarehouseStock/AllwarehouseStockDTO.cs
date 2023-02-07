using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.AllWarehouseStock
{
    public class AllwarehouseStockDTO
    {
        public string productCode { get; set; }
        public string sku { get; set; }
        public string productName { get; set; }
        public decimal mrp { get; set; }
        public decimal? sellingPrice { get; set; }
        public int totalPhysicalQty { get; set; }
        public int? totalVirualQty { get; set; }
        public string storeName { get; set; }
    }
}
