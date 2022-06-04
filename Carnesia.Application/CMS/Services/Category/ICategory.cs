using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.CMS.Category;
using Carnesia.Domain.CMS.CreateProduct;
using Microsoft.AspNetCore.Components.Forms;

namespace Carnesia.Application.CMS.Services.Category
{
    public interface ICategory
    {
        Task<List<ParentCategoryDTO>> GetCategories();

        Task UpdateParentCat(ParentUpdateDTO parentCat, int id);
        Task<string> CreateParentCat(CreateParentCatDTO parentCat);

        Task CreateChildCat(CreateChildCategoryDTO childCatData);
        Task UpdateChildCat(ChildUpdateDTO childCat, int id);

        Task DeleteCategory(int id);
        Task<string[]> GetParentCatAsString();
        Task<ParentCategoryDTO> GetParentCat(string ParentCat);
        Task<string[]> GetChildCatAsString(IList<ChildCategoryDTO> ChildCategories);
        Task<string[]> GetGrandChildCatAsString(IList<GrandChildCategoryDTO> GrandChildCategories);
        //Task<ProductCategoryDTO> GetChildCat(string ParentCat);
        //Task<string[]> GetGrandChildCatAsString();
        //Task<ProductCategoryDTO> GetGrandChildCat(string ParentCat);
    }
}
