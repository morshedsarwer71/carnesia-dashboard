using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.BunchProduct
{
    public class BunchProductDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public string code { get; set; }
        public string description { get; set; }
        public string imageUrl { get; set; }
        public decimal totalRegularPrice { get; set; }
        public decimal totalBunchPrice { get; set; }
    }
}
