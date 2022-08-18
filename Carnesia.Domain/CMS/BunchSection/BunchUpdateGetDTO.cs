using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.BunchSection
{
    public class BunchUpdateGetDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public string endDate { get; set; }
        public string endTime { get; set; }
        public string startDate { get; set; }
        public string startTime { get; set; }
        public string code { get; set; }
        public string description { get; set; }
        public string base64Attch { get; set; }
        public List<BunchUpdateProductTag> bunchProductTags { get; set; }
    }
    public class BunchUpdateProductTag
    {
        public int id { get; set; }
        public int productId { get; set; }
        public string sku { get; set; }
        public string product { get; set; }
        public string productCode { get; set; }
    }
}
