using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.TO.POCO
{
    public class GetProductCreateToPoco
    {
        public string message { get; set; }
        public CreateToProductPoco data { get; set; }
    }

    public class CreateToProductPoco
    {
        public string sku { get; set; }
        public string productCode { get; set; }
        public string productName { get; set; }
        public int sourceStock { get; set; }
        public int destinationStock { get; set; }
        public int qty { get; set; }
        public int quantity { get; set; }
    }
}
