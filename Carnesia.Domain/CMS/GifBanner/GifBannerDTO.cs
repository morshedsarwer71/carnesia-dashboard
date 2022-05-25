using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.GifBanner
{
    public class GifBannerDTO
    {
        public int id { get; set; }
        public string url { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public bool isPublish { get; set; }
        public string imagePath { get; set; }
        public object? imageFile { get; set; }
    }
}
