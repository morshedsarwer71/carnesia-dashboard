using Carnesia.Domain.CMS.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

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
    }
}
