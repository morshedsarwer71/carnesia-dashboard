using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.UpdateTO
{
    public class UpdateTODTO
    {
        public string productCode { get; set; }
        public string sku { get; set; }
        public string productName { get; set; }
        public int toQuantity { get; set; }
    }
}
