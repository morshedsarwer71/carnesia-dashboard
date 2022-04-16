using Carnesia.Domain.CMS.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Application.CMS.Services
{
    public interface IProduct
    {
        Task<ProductDTO> GetProducBySku(string sku);
    }
}
