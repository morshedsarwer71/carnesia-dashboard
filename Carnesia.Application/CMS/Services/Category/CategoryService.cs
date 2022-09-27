using Carnesia.Domain.CMS.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components.Forms;
using Carnesia.Domain.CMS.CreateProduct;

namespace Carnesia.Application.CMS.Services.Category
{
    public class CategoryService : ICategory
    {
        private readonly HttpClient _httpClient;
        public CategoryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task CreateChildCat(CreateChildCategoryDTO childCatData)
        {
            try
            {
                await _httpClient.PostAsJsonAsync("Category/child", childCatData);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task CreateGrandChildCat(CreateGrandChildCatDTO GrandChildCat)
        {
            try
            {
                await _httpClient.PostAsJsonAsync("Category/grandChild", GrandChildCat);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> CreateParentCat(CreateParentCatDTO parentCat)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("Category/parent", parentCat);

                if(result.IsSuccessStatusCode) return true;
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task DeleteCategory(int id)
        {
            try
            {
                await _httpClient.DeleteAsync($"Category/{id}");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<ParentCategoryDTO>> GetCategories()
        {
            try
            {
                var categories = await _httpClient.GetFromJsonAsync<List<ParentCategoryDTO>>("Category/categories");

                return categories;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<CategoryXLSLDTO>> GetCategoriesForXLSL()
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<CategoryXLSLDTO>>("Category/categorieslist");
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<string[]> GetChildCatAsString(IList<ChildCategoryDTO> ChildCategories)
        {
            var list = new List<string>();
            list.AddRange(ChildCategories.Select(x => x.childCat));
            
            return list.ToArray();
    
        }

        public async Task<string[]> GetChildCatAsStringByParentId(int id)
        {
            try
            {
                var list = new List<string>();
                var child = await _httpClient.GetFromJsonAsync<List<ChildCategoryDTO>>($"Category/childcategories/{id}");
                list.AddRange(child.Select(x => x.childCat));

                return list.ToArray();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<string[]> GetGrandChildCatAsString(IList<GrandChildCategoryDTO> GrandChildCategories)
        {
            var list = new List<string>();
            list.AddRange(GrandChildCategories.Select(x => x.gChildCat));

            return list.ToArray();
        }

        public async Task<string[]> GetGrandChildCatAsStringByChildId(int id)
        {
            try
            {
                var list = new List<string>();
                var gChild = await _httpClient.GetFromJsonAsync<List<GrandChildCategoryDTO>>($"Category/gchildcategories/{id}");
                list.AddRange(gChild.Select(x => x.gChildCat));

                return list.ToArray();

            }
            catch (Exception)
            {

                throw;
            }
        }

		public async Task<List<OnlyChildCategoryDTO>> GetOnlyChildCategory()
		{
			try
			{
                var result = await _httpClient.GetFromJsonAsync<List<OnlyChildCategoryDTO>>("Category/getchildcategories");
                return result;
			}
			catch (Exception)
			{

				throw;
			}
		}

		public async Task<ParentUpdateDTO> GetParentById(int id)
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<ParentUpdateDTO>($"Category/parentcategories/{id}");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<ParentCategoryDTO> GetParentCat(string ParentCat)
        {
            try
            {
                var categories = await GetCategories();
                return categories.FirstOrDefault(x => x.parentCat == ParentCat);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<string[]> GetParentCatAsString()
        {
            try
            {
                var list = new List<string>();
                var categories = await GetCategories();
                list.AddRange(categories.Select(x => x.parentCat));
                return list.ToArray();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task UpdateChildCat(ChildUpdateDTO childCat, int id)
        {
            try
            {
                await _httpClient.PutAsJsonAsync($"Category/child/{id}", childCat);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task UpdateParentCat(ParentUpdateDTO parentCat, int id)
        {
            try
            {
                await _httpClient.PutAsJsonAsync($"Category/parent/{id}", parentCat);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
