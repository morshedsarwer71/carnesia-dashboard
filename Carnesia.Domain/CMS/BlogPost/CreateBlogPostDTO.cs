﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.BlogPost
{
    public class CreateBlogPostDTO
    {
        public string title { get; set; }
        public string description { get; set; }
        public bool isPublish { get; set; } = true;
        public string base64Attch { get; set; }
    }
}
