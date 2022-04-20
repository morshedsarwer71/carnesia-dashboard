using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.UIDReport
{
    public class UIDReportDTO
    {
        public string PoCreationDate { get; set; }
        public string PoCloseDate { get; set; }
        public string POID { get; set; }
        public string SKU { get; set; }
        public string ProductName { get; set; }
        public string UID { get; set; }
        public string ExpiryDate { get; set; }
        public string ExpiryStatus { get; set; }
        public string LastOrder { get; set; }
        public string LastTOID { get; set; }
        public string LastPickListID { get; set; }
        public string Status { get; set; }
        public string StatusUpdateDate { get; set; }
        public string StatusUpdateBy { get; set; }
        public string LastBin { get; set; }
        public string Team { get; set; }
        public decimal LiftingPrice { get; set; }
    }
}
