using Carnesia.Domain.CMS.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components.Forms;

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

        public async Task CreateParentCat(CreateParentCatDTO parentCat)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("Category/parent", parentCat);

                if (result.IsSuccessStatusCode)
                {
                    var parentId = await result.Content.ReadAsStringAsync();
                }
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
                var categories = await _httpClient.GetFromJsonAsync<List<ParentCategoryDTO>>("Category");

                return categories;
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

        Task<string> ICategory.CreateParentCat(CreateParentCatDTO parentCat)
        {
            throw new NotImplementedException();
        }
    }
}
