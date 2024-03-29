﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CRM.Vouchers.GeneralVoucher.VoucherList
{
    public class VoucherListDTO
    {
        public int generalVId { get; set; }
        public string gvCode { get; set; }
        public int numOfVoucher { get; set; }
        public string startDate { get; set; }
        public string startTime { get; set; }
        public string endDate { get; set; }
        public string endTime { get; set; }
        public decimal minCartAmount { get; set; }
        public string platformType { get; set; }
        public string voucherDiscType { get; set; }
        public decimal discAmntOrPercent { get; set; }
        public decimal upToDiscAmnt { get; set; }
        public object approvalDate { get; set; }
        public string approvedBy { get; set; }
        public string description { get; set; }
        public bool isEnable { get; set; }
    }
}
