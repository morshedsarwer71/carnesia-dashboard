using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.UpdateTO
{
    public class DeleteToProductsDTO
    {
        public string toCode { get; set; }
        public List<int> productId { get; set; }
    }
}
