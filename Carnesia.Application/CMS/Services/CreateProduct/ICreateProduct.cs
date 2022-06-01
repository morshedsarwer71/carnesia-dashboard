using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.CMS.CreateProduct;

namespace Carnesia.Application.CMS.Services.CreateProduct
{
    public interface ICreateProduct
    {
        Task<string> CreateParentProduct(ParentProductDTO ParentProduct);
    }
}
