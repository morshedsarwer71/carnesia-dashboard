using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.PO.POCO
{
    public class BulkUIDPoco
    {
        public string poCode { get; set; }
        public string productCode { get; set; }
        public string profileCode { get; set; }
        public int generateuidQty { get; set; }
        public string expDate { get; set; }
    }
}
