﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.OMS.PendingOrder
{
    public class PendingOrderDetailsDTO
    {
        public string SKU { get; set; }
        public string ProductName { get; set; }
        public int QTY { get; set; }
        public decimal Price { get; set; }
        public decimal Amount { get; set; }
    }
}