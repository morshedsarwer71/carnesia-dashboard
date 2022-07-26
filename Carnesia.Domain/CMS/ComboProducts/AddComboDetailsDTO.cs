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
        public decimal regularPrice { get; set; }
        public decimal comboPrice { get; set; }
        public string description { get; set; }
        public int storeId { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public string base64Attach { get; set; }
    }
}
