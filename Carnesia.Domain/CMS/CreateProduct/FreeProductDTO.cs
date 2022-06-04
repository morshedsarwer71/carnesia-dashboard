using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.CreateProduct
{
    public class FreeProductDTO
    {
        public string name { get; set; }
        public string sku { get; set; }
        public int price { get; set; }
        public int numbOfFreeProd { get; set; }
        public string base64Attch { get; set; }
        public string imageName { get; set; }
        public string description { get; set; }
    }
}
