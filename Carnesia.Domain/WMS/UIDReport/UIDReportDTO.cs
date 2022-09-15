using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.UIDReport
{
    public class UIDReportDTO
    {
        public string? poCreated { get; set; }
        public string? poClosed { get; set; }
        public string poCode { get; set; }
        public string productCode { get; set; }
        public string sku { get; set; }
        public string productName { get; set; }
        public string uid { get; set; }
        public decimal liftingPrice { get; set; }
        public string expDate { get; set; }
        public string expStatus { get; set; }
        public string warehouse { get; set; }
        public string lastOrder { get; set; }
        public string? lastToCode { get; set; }
        public string? lastPickCode { get; set; }
        public string status { get; set; }
        public string lastUpdateDate { get; set; }
        public string team { get; set; }
        public string lastUpdateBy { get; set; }
        public string lastBin { get; set; }
    }

    public class UIDReportFilterDTO
    {
        public int storeId { get; set; }
        public string? poCode { get; set; }
        public DateTime? fromDate { get; set; }
        public DateTime? toromDate { get; set; }
        public int statusId { get; set; }
        public string? sku { get; set; }
        public string? uid { get; set; }
        public string? toCode { get; set; }
        public string? oderCode { get; set; }
        public string? productCode { get; set; }
        public int teamId { get; set; }
        public DateTime? fromPo { get; set; }
        public DateTime? toPo { get; set; }
        public DateTime? fromClosedPo { get; set; }
        public DateTime? toClosedPo { get; set; }

    }
}
