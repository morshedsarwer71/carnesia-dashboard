using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.CMS.Models;
using Carnesia.Domain.Common.ResponseData;
using Newtonsoft.Json;

namespace Carnesia.Application.CMS.Services
{
    public class ProductService : IProduct
    {
        private readonly HttpClient _httpClient;
        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<ProductDTO> GetProducBySku(string sku)
        {
            try
            {
                var product = await _httpClient.GetFromJsonAsync<ProductDTO>($"Products/getproductbysku/{sku}");
                if (product == null)
                    return null;
                return product;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return new ProductDTO(){description = e.Message};
            }
        }

        public async Task<List<ProductDTO>> GetProducts()
        {
            try
            {
                var products = await _httpClient.GetFromJsonAsync<List<ProductDTO>>("Products/GetAllProducts");
                return products;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<string> CreateProduct(CreateProductDTO createProduct)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("Products", createProduct);
                if (result.IsSuccessStatusCode)
                {
                    var poCode = await result.Content.ReadAsStringAsync();
                    var deserialized = JsonConvert.DeserializeObject<string>(poCode);
                    return deserialized;
                }

                return null;
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }
    }
}
