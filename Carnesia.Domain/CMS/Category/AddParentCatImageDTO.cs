using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.Category
{
    public class AddParentCatImageDTO
    {
        public int parentCategoryId { get; set; }
        public ImageDTO ImageFile { get; set; }
    }
}
