using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.CMS.Models;

namespace Carnesia.Application.CMS.Services
{
    public interface IProduct
    {
        Task<ProductDTO> GetProducBySku(string sku);
        Task<List<ProductDTO>> GetProducts();
        Task<string> CreateProduct(CreateProductDTO createProduct);

    }
}
