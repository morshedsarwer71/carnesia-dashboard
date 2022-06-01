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
        Task CreateBrand(CreateBrandDTO NewBrand);
        Task UpdateBrand(CreateBrandDTO NewBrand, int BrandId);

        Task<string[]> GetBrandsNameAsString();
        Task<BrandDTO> GetBrand(string BrandName);
    }
}
