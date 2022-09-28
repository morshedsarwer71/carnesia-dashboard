using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.CMS.ProductList;

namespace Carnesia.Application.CMS.Services.ProductList
{
    public interface IProductList
    {
        Task<List<ProductListDTO>> GetProducts();
        Task<List<ProductQuickSettingDTO>> GetAllProducts();
        Task<List<ProductQuickSettingDTO>> GetAllUnapprovedProducts();
        Task<bool> QuickSetting(ProductQuickSettingUpdateDTO product);
        Task<bool> ApproveProduct(int id);
        Task<List<ProductListV2DTO>> GetProductsV2(int prev, int next);
        Task<List<ProductListV2DTO>> GetProductsBySearchV2(ProductListFilterV2DTO Filter);
        Task<List<ProductListV2DTO>> GetProductsForDownloadV2();
    }
}
