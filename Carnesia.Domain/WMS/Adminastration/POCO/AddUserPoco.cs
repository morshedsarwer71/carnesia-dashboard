using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.Adminastration.POCO
{
    public class AddUserPoco
    {
        public string username { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }
        public string password { get; set; } 
        public string storeName { get; set; }
        public int storeId { get; set; }
    }
}
