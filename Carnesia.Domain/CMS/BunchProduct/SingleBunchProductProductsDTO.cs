using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.BunchProduct
{
    public class SingleBunchProductProductsDTO
    {
        public int id { get; set; }
        public int productId { get; set; }
        public string sku { get; set; }
        public string product { get; set; }
        public string productCode { get; set; }
        public decimal regularPrice { get; set; }
        public decimal sellingPrice { get; set; }
    }
}
