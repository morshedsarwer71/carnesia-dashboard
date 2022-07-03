using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.ChildProduct
{
    public class BulkImageUploadDTO
    {
        public string imageURL { get; set; }
        public string imageName { get; set; }
        public string altText { get; set; }
        public int productId { get; set; }
    }
}
