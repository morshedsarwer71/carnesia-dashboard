using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.BunchSection
{
    public class BunchSectionListDTO
    {
        public int id { get; set; }
        public string sectionName { get; set; }
        public string sectionCode { get; set; }
        public bool isPublished { get; set; }
        public bool isHome { get; set; }
        public string allignment { get; set; }
        public bool ShowDetails { get; set; }
        public IList<BunchThumListDTO> bunchThums { get; set; }
    }

    public class BunchThumListDTO
    {
        public int id { get; set; }
        public string sectionCode { get; set; }
        public string name { get; set; }
        public string imageUrl { get; set; }
        public string link { get; set; }
        public bool isPublished { get; set; }
    }
}
