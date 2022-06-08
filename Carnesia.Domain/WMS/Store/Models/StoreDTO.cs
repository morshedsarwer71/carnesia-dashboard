using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.Store.Models
{
    public class StoreDTO
    {
        public int storeId { get; set; }
        public string storeName { get; set; }
        public string address { get; set; }
        public string storeSize { get; set; }
        //public int numberOfRack { get; set; }
    }
}
