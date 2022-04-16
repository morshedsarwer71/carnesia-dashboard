using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.PO.Models
{
    public class CreatePODTO
    {
        public string poType { get; set; }
        public DateTime? receiveDate { get; set; }
        public int vendorId { get; set; }
        public string vendorName { get; set; }
        public int poRcvStoreId { get; set; }
        public string storeName { get; set; }
        public string description { get; set; }
    }
}
