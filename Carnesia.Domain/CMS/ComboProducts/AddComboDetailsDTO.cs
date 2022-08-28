using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.ComboProducts
{
    public class AddComboDetailsDTO
    {
        public string comboProductName { get; set; }
        public string sku { get; set; }
        public int productId { get; set; }
        public int regularPrice { get; set; }
        public int comboPrice { get; set; }
        public string description { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public string base64Attch { get; set; }
    }
}
