using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.BunchProduct
{
    public class AddBunchProductDTO
    {
        public string name { get; set; }
        public string description { get; set; }
        public string base64Attch { get; set; }
        public bool isPublished { get; set; } = true;
        public List<AddBunchProductProductsDTO> bunchProductTag { get; set; }
    }
}
