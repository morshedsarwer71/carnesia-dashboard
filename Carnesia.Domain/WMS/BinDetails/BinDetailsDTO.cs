﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.BinDetails
{
    public class BinDetailsDTO
    {
        public string ProductCode { get; set; }
        public string SKU { get; set; }
        public string ProductName { get; set; }
        public string BIN { get; set; }
        public int QTY { get; set; }
    }
}
