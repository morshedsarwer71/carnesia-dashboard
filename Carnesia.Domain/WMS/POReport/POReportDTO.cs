using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.POReport
{
    public class POReportDTO
    {
        public DateTime creationDate { get; set; }
        public string vendorName { get; set; }
        public string poCode { get; set; }
        public string recvWarehouse { get; set; }
        public string sku { get; set; }
        public string productCode { get; set; }
        public string productName { get; set; }
        public decimal liftingPrice { get; set; }
        public int poQty { get; set; }
        public int recvPoQty { get; set; }
        public int notArrived { get; set; }
        public int uidgenerated { get; set; }
        public int inScanComplete { get; set; }
    }

    public class POReportFilterDTO
    {
        public int storeId { get; set; }
        public string? productCode { get; set; }
        public string? poCode { get; set; }
        public string? sku { get; set; }
        public string? productName { get; set; }
        public DateTime? poFromDate { get; set; }
        public DateTime? poToDate { get; set; }
        public DateTime? recvFromDate { get; set; }
        public DateTime? recvToDate { get; set; }
        public int vendorId { get; set; }
        public int previous { get; set; } = 0;
        public int next { get; set; } = 25;
    }
}
