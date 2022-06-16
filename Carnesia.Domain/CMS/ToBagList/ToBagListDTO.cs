using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.ToBagList
{
    public class ToBagListDTO
    {
        public int id { get; set; }
        public string sectionCode { get; set; }
        public string name { get; set; }
        public string imageUrl { get; set; }
        public string link { get; set; }
        public bool isPublished { get; set; }
    }
}
