using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.CMS.Products;

namespace Carnesia.Application.CMS.Services.Products
{
    public interface IProducts
    {
        Task<List<ProductsDTO>> GetProducts();

        Task<string[]> GetProductsAsSKU();

        Task<int> GetProductIdBySku(string sku); 
    }
}
