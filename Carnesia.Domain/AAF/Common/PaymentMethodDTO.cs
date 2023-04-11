using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.AAF.Common
{
    public class PaymentMethodDTO
    {
        public string name { get; set; }
        public int chargeId { get; set; }
        public int paymentId { get; set; }
    }
}
