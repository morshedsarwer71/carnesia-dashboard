using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.Category
{
    public class ParentUpdateDTO
    {
        public int id { get; set; }
        public string parentCat { get; set; }
        public string imageUrl { get; set; }
        public string base64Attch { get; set; }
    }
}
