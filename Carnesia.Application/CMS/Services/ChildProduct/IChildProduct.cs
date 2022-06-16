using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.CMS.ChildProduct;

namespace Carnesia.Application.CMS.Services.ChildProduct
{
    public interface IChildProduct
    {
        Task CreateChildProduct(ChildProductDTO ProductData);

    }
}
