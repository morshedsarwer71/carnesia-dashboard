using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.Category
{
    public class GrandChildCategoryDTO
    {
        public int id { get; set; }
        public int childId { get; set; }
        public string gChildCat { get; set; }
        public List<GreatGrandChildDTO>? ggChild { get; set; }
    }
}
