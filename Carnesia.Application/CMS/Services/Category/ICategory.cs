using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.CMS.Category;
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
    }
}
