using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.HomeCarousel
{
    public class AddHomeCarouselDTO
    {
        public string name { get; set; }
        public string url { get; set; }
        public bool isPublish { get; set; } = true;
        public string base64AttchMobile { get; set; }
        public string base64AttchPc { get; set; }
    }
}
