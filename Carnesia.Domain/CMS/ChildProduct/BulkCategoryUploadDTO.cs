using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.ChildProduct
{
    public class BulkCategoryUploadDTO
    {
        public int parentCatId { get; set; }
        public int childCatId { get; set; }
        public int gChildCatId { get; set; }
        public string productCode { get; set; }
        public string description { get; set; }
    }
}
