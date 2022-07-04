using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.Category
{
    public class CategoryXLSLDTO
    {
        public int id { get; set; }
        public string parentCat { get; set; }
        public int parentId { get; set; }
        public object childCat { get; set; }
        public int childCatId { get; set; }
        public object gChildCat { get; set; }
        public int gChildCatId { get; set; }
    }
}
