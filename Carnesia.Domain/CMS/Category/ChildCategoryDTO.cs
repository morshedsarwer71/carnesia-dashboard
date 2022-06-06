using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.Category
{
    public class ChildCategoryDTO
    {
        public int id { get; set; }
        public int parentId { get; set; }
        public string childCat { get; set; }
        public bool showDetails { get; set; } = false;
        public IList<GrandChildCategoryDTO>? grandChild { get; set; }
    }
}
