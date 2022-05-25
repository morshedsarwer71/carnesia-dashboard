using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.HomeCarousel
{
    public class HomeCarouselDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public string url { get; set; }
        public bool isPublish { get; set; }
        public string imagePath { get; set; }
    }
}
