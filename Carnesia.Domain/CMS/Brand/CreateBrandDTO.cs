using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.Brand
{
    public class CreateBrandDTO
    {
        public string name { get; set; }
        public string description { get; set; }
        public bool isPublished { get; set; } = true;
        public string base64Attch { get; set; }
    }
}
