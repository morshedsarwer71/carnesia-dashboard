using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.BinAudit
{
    public class BinAuditDTO
    {
        public string ItemCode { get; set; }
        public string ProductName { get; set; }
        public string BIN { get; set; }
        public int QTY { get; set; }
        public int FoundQTY { get; set; }
        public int MissingQTY { get; set; }
    }
}
