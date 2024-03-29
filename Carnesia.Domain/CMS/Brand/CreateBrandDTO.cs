﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.Brand
{
    public class CreateBrandDTO
    {
        public int brandId { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public bool isPublished { get; set; } = true;
        public string imageUrl { get; set; }
        public string base64Attch { get; set; }
        public string logoBase64Attch { get; set; }
    }
}
