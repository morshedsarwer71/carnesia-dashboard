using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.CMS.Brand;

namespace Carnesia.Application.CMS.Services.Brand
{
    public interface IBrand
    {
        Task<List<BrandDTO>> GetBrands();
        Task<CreateBrandDTO> GetBrandById(int id);
        Task CreateBrand(CreateBrandDTO NewBrand);
        Task UpdateBrand(CreateBrandDTO Brand);

        Task<string[]> GetBrandsNameAsString();
        Task<BrandDTO> GetBrand(string BrandName);
        Task<bool> ToggleBrand(int id);
        Task<bool> ToggleTopBrands(int id);
    }
}
