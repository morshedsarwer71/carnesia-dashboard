using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.BunchProduct
{
    public class SingleBunchProductDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public string endDate { get; set; }
        public string endTime { get; set; }
        public string startDate { get; set; }
        public string startTime { get; set; }
        public string code { get; set; }
        public string description { get; set; }
        public string imageUrl { get; set; }
        public decimal totalRegularPrice { get; set; }
        public decimal totalBunchPrice { get; set; }
        public string base64Attch { get; set; }
        public List<SingleBunchProductProductsDTO> bunchProductTags { get; set; }
    }
}
