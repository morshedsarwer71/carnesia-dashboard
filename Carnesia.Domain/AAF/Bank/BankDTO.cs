using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.AAF.Bank
{
    public class BankDTO
    {
        public int id { get; set; }
        public string bankName { get; set; }
        public string bankAddress { get; set; }
        public string accountNumber { get; set; }
        public string contactNumber { get; set; }
    }
}
