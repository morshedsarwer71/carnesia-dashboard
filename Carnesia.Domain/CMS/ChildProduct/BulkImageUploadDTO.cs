﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.ChildProduct
{
    public class BulkImageUploadDTO
    {
        public string url { get; set; }
        public string imageName { get; set; }
        public string altImageName { get; set; }
        public string productCode { get; set; }
        public string description { get; set; }
    }
}
