using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.Common.Customer
{
    public class CustomerInfoBulkUploadDTO
    {
        public string customerId { get; set; }
        public string name { get; set; }
        public string userName { get; set; }
        public string phoneNumber { get; set; }
        public string password { get; set; }
    }
}
