using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.ComboProducts
{
    public class CreateBogoComboBannerDTO
    {
        public string name { get; set; }
        public string base64 { get; set; }
    }

    public class BogoComboBannerDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public string imageUrl { get; set; }
        public bool isPublish { get; set; }
        public bool isHome { get; set; }
    }
}
