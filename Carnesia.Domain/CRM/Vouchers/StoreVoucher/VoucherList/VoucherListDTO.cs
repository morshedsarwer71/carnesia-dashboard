﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CRM.Vouchers.StoreVoucher.VoucherList
{
    public class VoucherListDTO
    {
        public int id { get; set; }
        public string voucherCode { get; set; }
        public int numOfVoucher { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public decimal minCartAmount { get; set; }
        public string voucherDiscType { get; set; }
        public decimal discAmntOrPercent { get; set; }
        public decimal upToDiscAmnt { get; set; }
        public string description { get; set; }
        public List<VoucherListStoreDTO> voucherStores { get; set; }
    }
}