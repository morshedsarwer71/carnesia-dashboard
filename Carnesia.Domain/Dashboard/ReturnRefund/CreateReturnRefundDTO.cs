using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.Dashboard.ReturnRefund
{
    public class CreateReturnRefundDTO
    {
        public PosDetails pos { get; set; }
        public List<PosItem> items { get; set; }
        public List<PosUID> posUID { get; set; }
    }

    public class PosUID
    {
        public string uid { get; set; }
    }

    public class PosItem
    {
        public string productCode { get; set; }
        public decimal price { get; set; }
        public int quantity { get; set; }
        public decimal totalPrice { get; set; }
    }

    public class PosDetails
    {
        public decimal total { get; set; }
        public int items { get; set; }
        public int customerId { get; set; }
        public int quantities { get; set; }
        public decimal vat { get; set; }
        public decimal vatAmount { get; set; }
        public decimal grandTotal { get; set; }
        public string comment { get; set; }
        public string trnCode { get; set; }
    }
}
