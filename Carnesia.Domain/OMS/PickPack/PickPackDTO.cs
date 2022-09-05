using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.OMS.PickPack
{
    public class PickPackDTO
    {
        public string sku { get; set; }
        public string productCode { get; set; }
        public string productName { get; set; }
        public string picklistId { get; set; }
        public int qty { get; set; }
        public int packedQty { get; set; }
        public int toBeScanned { get; set; }
    }
}
