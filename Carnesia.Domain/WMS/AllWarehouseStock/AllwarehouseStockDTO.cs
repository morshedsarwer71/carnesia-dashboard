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
		public int centralTotalPhysicalQty { get; set; }
		public int? centralTotalVirualQty { get; set; }
        public int mirpurTotalPhysicalQty { get; set; }
		public int? mirpurTotalVirualQty { get; set; }
        public int bashundharaCityTotalPhysicalQty { get; set; }
        public int? bashundharaCityTotalVirualQty { get; set; }
        public int baileyRoadTotalPhysicalQty { get; set; }
        public int? baileyRoadTotalVirualQty { get; set; }
        public int dhanmondiTotalPhysicalQty { get; set; }
        public int? dhanmondiTotalVirualQty { get; set; }
        public int khulsiTotalPhysicalQty { get; set; }
        public int? khulsiTotalVirualQty { get; set; }
        public int finlayTotalPhysicalQty { get; set; }
        public int? finlayTotalVirualQty { get; set; }
        public int sylhetKumarparaTotalPhysicalQty { get; set; }
        public int? sylhetKumarparaTotalVirualQty { get; set; }
    }
}
