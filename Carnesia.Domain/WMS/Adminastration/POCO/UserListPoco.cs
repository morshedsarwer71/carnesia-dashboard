using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.Adminastration.POCO
{
    public class UserListPoco
    {
        public string id { get; set; }
        public string name { get; set; }
        public string userName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string hub { get; set; }
        public string deparment { get; set; }
        public string designation { get; set; }
        public bool isActive { get; set; }
    }
}
