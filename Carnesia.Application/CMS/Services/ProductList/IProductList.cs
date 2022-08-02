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
    }
}
