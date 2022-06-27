using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.PO.POCO
{
    public class UIDProfileDTO
    {
        public int mrp { get; set; }
        public string sku { get; set; }
        public string productCode { get; set; }
        public bool isLabelPrint { get; set; }
        public DateTime expDate { get; set; }
        public int generatedSKUQty { get; set; }
        public string uid { get; set; }
    }
}
