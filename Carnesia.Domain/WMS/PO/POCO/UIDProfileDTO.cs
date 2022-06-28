using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.PO.POCO
{
    public class UIDProfileDTO
    {
        public decimal mrp { get; set; }
        public string sku { get; set; }
        public string productCode { get; set; }
        public bool isLabelPrint { get; set; }
        public string expDate { get; set; }
        public string paramDate { get; set; }
        public int generatedSKUQty { get; set; }
        public string vendor { get; set; }
        public string addressOne { get; set; }
        public string addressTwo { get; set; }
        public List<UIDDataPoco> uid { get; set; }
    }
}
