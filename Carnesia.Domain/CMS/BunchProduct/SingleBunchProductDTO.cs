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
        public string code { get; set; }
        public string description { get; set; }
        public string base64Attch { get; set; }
        public List<SingleBunchProductProductsDTO> bunchProductTags { get; set; }
    }
}
