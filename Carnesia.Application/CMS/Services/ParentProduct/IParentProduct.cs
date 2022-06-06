using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.CMS.ParentProduct;
using Carnesia.Domain.CMS.SimpleProduct;

namespace Carnesia.Application.CMS.Services.ParentProduct
{
    public interface IParentProduct
    {
        Task<List<ParentProductDTO>> GetParentProducts();

        Task CreateParentProduct(CreateParentProductDTO ParentProduct);
        Task<string> CreateParentProductReturnID(SimpleProductParentDTO ParentProduct);

        Task<string[]> GetParentProductAsString();

        Task<int> GetParentProductID(string ProductName);
        Task UpdateParentProduct(ParentProductDTO ParentProduct);
    }
}
