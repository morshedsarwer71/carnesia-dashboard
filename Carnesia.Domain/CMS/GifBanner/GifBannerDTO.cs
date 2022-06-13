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
        public string imageFileUrl { get; set; }
        public string imageWebUrl { get; set; }
        public object approvedBy { get; set; }
        public DateTime approvelDate { get; set; }
        public object approvalNote { get; set; }
        public object createdBy { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public object updatedBy { get; set; }
        public int modifiedId { get; set; }
        public bool isDelete { get; set; }
    }
}
