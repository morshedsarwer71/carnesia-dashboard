using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.OMS.Zones
{
    public class CustomerDeliveryAddressDTO
    {
        public string customerID { get; set; }
        public string name { get; set; }
        public string houseNo { get; set; }
        public string detailAddress { get; set; }
        public int district { get; set; }
        public string zip { get; set; }
        public string contactNumber { get; set; }
        public string roadNo { get; set; }
        public int zone { get; set; }
        public int division { get; set; }
        public decimal shipping { get; set; }
        public string saveAddressAs { get; set; } = "CS";
        public string otp { get; set; }
        public bool isDefault { get; set; } = false;
        public string editFor { get; set; }
    }

    public class CustomerDeliveryAddressGetDTO
    {
        public int addressId { get; set; }
        public string customerID { get; set; }
        public string name { get; set; }
        public string houseNo { get; set; }
        public string detailAddress { get; set; }
        public string district { get; set; }
        public string zip { get; set; }
        public string contactNumber { get; set; }
        public string roadNo { get; set; }
        public string zone { get; set; }
        public string division { get; set; }
        public string saveAddressAs { get; set; }
        public bool isDelete { get; set; }
        public bool isDefault { get; set; }
    }
}
