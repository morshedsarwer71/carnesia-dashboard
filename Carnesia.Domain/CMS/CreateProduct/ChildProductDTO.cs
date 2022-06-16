using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.CreateProduct
{
    public class ChildProductDTO
    {
        public string pproductType { get; set; }
        public string parentName { get; set; }
        public string childName { get; set; }
        public string sku { get; set; }
        public bool isPublish { get; set; }
        public string brandName { get; set; }
        public string origin { get; set; }
        public int childId { get; set; }
    }
}
