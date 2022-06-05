using Carnesia.Domain.CMS.ParentProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace Carnesia.Application.CMS.Services.ParentProduct
{
    public class ParentProductService : IParentProduct
    {
        private readonly HttpClient _httpClient;
        public ParentProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task CreateParentProduct(CreateParentProductDTO ParentProduct)
        {
            try
            {
                await _httpClient.PostAsJsonAsync("ProductParent", ParentProduct);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<string[]> GetParentProductAsString()
        {
                var list = new List<string>();
                var products = await GetParentProducts();
                list.AddRange(products.Select(x => x.name));
                return list.ToArray();
        }

        public async Task<int> GetParentProductID(string ProductName)
        {
            try
            {
                var products = await GetParentProducts();
                return products.FirstOrDefault(x => x.name == ProductName).id;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<ParentProductDTO>> GetParentProducts()
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<ParentProductDTO>>("ProductParent");
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
