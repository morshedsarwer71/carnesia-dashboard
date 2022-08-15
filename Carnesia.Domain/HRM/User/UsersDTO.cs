using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.HRM.User
{
    public class UsersDTO
    {
        public string id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string userType { get; set; }
        public int? customerId { get; set; }
        public bool isActive { get; set; }
        public string concat { get; set; }
    }
}
