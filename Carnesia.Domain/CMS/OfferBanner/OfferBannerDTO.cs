using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.OfferBanner
{
    public class OfferBannerDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public string imageUrl { get; set; }
        public string url { get; set; }
        public bool isPublished { get; set; }
    }
}
