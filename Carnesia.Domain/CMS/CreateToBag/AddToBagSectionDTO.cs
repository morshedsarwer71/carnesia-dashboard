using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.CreateToBag
{
    public class AddToBagSectionDTO
    {
        public string sectionName { get; set; }
        public bool isPublished { get; set; } = true;
    }
}
