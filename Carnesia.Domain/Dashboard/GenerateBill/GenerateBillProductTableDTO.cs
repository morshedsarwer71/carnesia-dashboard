using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.Dashboard.GenerateBill
{
    public class GenerateBillProductTableDTO
    {
        public string productName { get; set; }
        public string productSKU { get; set; }
        public decimal mrp { get; set; }
        public decimal sellingPrice { get; set; }
        public int qty { get; set; }
    }
}
