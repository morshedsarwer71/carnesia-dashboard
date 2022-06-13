using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.GifBanner
{
    public class AddGifBannerDTO
    {
        public string url { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string extension { get; set; }
        public bool isPublish { get; set; } = true;
        public string base64Attch { get; set; }
    }
}
