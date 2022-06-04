using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.ParentProduct
{
    public class ParentProductDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public int brandID { get; set; }
        public string brand { get; set; }
        public string originId { get; set; }
        public string description { get; set; }
        public string productType { get; set; }
    }
}
