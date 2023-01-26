using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.AAF.Receivable.Invoice
{
    public class InvoiceListDTO
    {
        public DateTime dateTime { get; set; }
        public string invoiceNumber { get; set; }
        public decimal invoiceAmount { get; set; }
        public decimal receivedAmount { get; set; }
        public decimal lost { get; set; }
        public decimal receivePending { get; set; }
        public string store { get; set; }
        public string bu { get; set; }
    }
}
