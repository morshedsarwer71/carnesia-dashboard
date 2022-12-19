using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.Dashboard.GenerateBill
{
    public class GenerateBillComboDetailsDTO
    {
        public string name { get; set; }
        public string bcCode { get; set; }
        public string bcType { get; set; }
        public string comboCode { get; set; }
        public decimal regularPrice { get; set; }
        public decimal salesPrice { get; set; }
        public List<GenerateBillComboProductDetailsDTO> products { get; set; }
        public List<GenerateBillUIDCollectionDTO> uids { get; set; }
    }

    public class GenerateBillComboProductDetailsDTO
    {
        public int productId { get; set; }
        public string productCode { get; set; }
        public string sku { get; set; }
        public string productName { get; set; }
        public int tobeScan { get; set; }
        public int scanned { get; set; }
    }
}
