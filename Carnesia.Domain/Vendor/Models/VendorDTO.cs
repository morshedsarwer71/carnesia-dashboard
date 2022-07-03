﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.Vendor.Models
{
    public class VendorDTO
    {
        public int vendorId { get; set; }
        public string name { get; set; }
        public string initial { get; set; }
        public string owner { get; set; }
        public string bankAccountDetails { get; set; }
        public string managerName { get; set; }
        public string phoneNumber { get; set; }
        public string importer { get; set; }
        public string addressOne { get; set; }
        public string addressTwo { get; set; }
    }
}
