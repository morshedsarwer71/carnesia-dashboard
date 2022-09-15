using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.OMS.PickPack
{
    public class PickPackDTO
    {
        public string message { get; set; }
        public string? instructions { get; set; }
        public string? expiryDate { get; set; }
        public string? expStatus { get; set; }
        public List<pickPackProductsDTO>? pickPacks { get; set; }
    }

    public class pickPackProductsDTO
    {
        public object pickListId { get; set; }
        public string productCode { get; set; }
        public string sku { get; set; }
        public string productName { get; set; }
        public int totalQty { get; set; }
        public int totalPickedQty { get; set; }
        public int totalReturnQty { get; set; }
    }
}
