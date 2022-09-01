using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.UpdateTO
{
    public class UpdateTODTO
    {
        public string toCode { get; set; }
        public string createdDate { get; set; }
        public string sourceWh { get; set; }
        public string destinationWh { get; set; }
        public string createdBy { get; set; }
        public string pickCode { get; set; }
        public List<UpdateToProductsDTO> products { get; set; }
    }

    public class UpdateToProductsDTO
    {
        public int id { get; set; }
        public string productName { get; set; }
        public string sku { get; set; }
        public string prodcutCode { get; set; }
        public int quantity { get; set; }
    }
}
