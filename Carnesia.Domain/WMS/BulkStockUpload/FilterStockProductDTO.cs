using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.BulkStockUpload
{
    public class FilterStockProductDTO
    {
        public string productCode { get; set; }
        public string sku { get; set; }
        public string productName { get; set; }
        public string? bin { get; set; }
        public int binId { get; set; }
        public int stock { get; set; }
    }

    public class StockFilterDTO
    {
        public int storeId { get; set; }
        public int stockType { get; set; }
    }
}
