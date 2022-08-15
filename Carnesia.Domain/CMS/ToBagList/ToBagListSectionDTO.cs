using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.ToBagList
{
    public class ToBagListSectionDTO
    {
        public int id { get; set; }
        public string sectionName { get; set; }
        public string sectioncode { get; set; }
        public string allignment { get; set; }
        public bool isPublished { get; set; }
        public bool isHome { get; set; }
        public List<ToBagListDTO> tobags { get; set; }
        public bool ShowDetails { get; set; } = false;
    }
}
