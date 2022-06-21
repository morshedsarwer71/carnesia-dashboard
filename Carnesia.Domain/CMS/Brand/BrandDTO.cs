using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.Brand
{
    public class BrandDTO
    {
        public int brandId { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public bool isPublished { get; set; }
        public string imageUrl { get; set; }
    }
}
