using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.ProductList
{
    public class ProductBulkPublishDTO
    {
        public string productSku { get; set; }
        public string productCode { get; set; }
        public int isPublish { get; set; }
    }
}
