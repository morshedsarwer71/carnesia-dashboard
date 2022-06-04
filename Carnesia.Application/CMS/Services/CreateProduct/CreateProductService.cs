using Carnesia.Domain.CMS.CreateProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace Carnesia.Application.CMS.Services.CreateProduct
{
    public class CreateProductService : ICreateProduct
    {
        private readonly HttpClient _httpClient;
        public CreateProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task CreateChildProduct(ProductDTO ProductData)
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

        public async Task<string> CreateParentProduct(ParentProductDTO ParentProduct)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("ProductParent", ParentProduct);
                if (result.IsSuccessStatusCode)
                {
                    var parentID = await result.Content.ReadAsStringAsync();
                    return parentID;
                }
                return String.Empty;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
