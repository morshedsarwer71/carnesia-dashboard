﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.Category
{
    public class CreateChildCategoryDTO
    {
        public int parentId { get; set; }
        public string childCat { get; set; }
    }
}
