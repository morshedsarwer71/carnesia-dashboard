using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.Category
{
    public class ParentCategoryDTO
    {
        public int id { get; set; }
        public string parentCat { get; set; }
        public string? imageUrl { get; set; }
        public bool showDetails { get; set; } = false;
        public IList<ChildCategoryDTO>? child { get; set; }
    }
}
