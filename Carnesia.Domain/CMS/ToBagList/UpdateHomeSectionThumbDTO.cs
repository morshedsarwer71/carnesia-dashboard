using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.ToBagList
{
    public class UpdateHomeSectionThumbDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
        public bool isPublished { get; set; }
        public string base64Attach { get; set; }
        public string alignment { get; set; }
    }
}
