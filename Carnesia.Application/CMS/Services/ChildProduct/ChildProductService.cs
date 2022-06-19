using Carnesia.Domain.CMS.ChildProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace Carnesia.Application.CMS.Services.ChildProduct
{
    public class ChildProductService : IChildProduct
    {
        private readonly HttpClient _httpClient;
        public ChildProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task CreateChildProduct(ChildProductDTO ProductData)
        {
            try
            {
                await _httpClient.PostAsJsonAsync("Products", ProductData);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task DeleteImage(int id)
        {
            try
            {
                await _httpClient.DeleteAsync($"Products/deleteproductimage/{id}");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<SingleChildProductDTO> GetChildById(int id)
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<SingleChildProductDTO>($"Products/{id}");
                if (result == null)
                {
                    return null;
                }

                return result;
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

        public async Task UpdateChildProduct(ChildProductUpdateDTO childProduct)
        {
            try
            {
                await _httpClient.PutAsJsonAsync($"Products/{childProduct.updateProductDTO.id}", childProduct);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task UpdateImage(UpdateProductImageDTO Images, int id)
        {
            try
            {
                await _httpClient.PostAsJsonAsync($"Products/addimagetoproducts/{id}", Images);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
