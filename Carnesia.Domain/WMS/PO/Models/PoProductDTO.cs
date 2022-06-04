using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.PO.Models
{
    public class PoProductDTO
    {
        public string sku { get; set; }
        public string productName { get; set; }
        public int quantity { get; set; }
        public decimal liftingPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal total { get; set; }
    }
}
