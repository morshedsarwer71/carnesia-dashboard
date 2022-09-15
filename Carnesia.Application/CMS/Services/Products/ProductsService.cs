using Carnesia.Domain.CMS.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace Carnesia.Application.CMS.Services.Products
{
    public class ProductsService : IProducts
    {
        private readonly HttpClient _httpClient;
        public ProductsService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<int> GetProductIdBySku(string sku)
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<ProductsBySKUDTO>($"Products/getproductbysku/{sku}");

                if (result != null) return result.productId;
                return 0;
            }
            catch (Exception)
            {

                return 0;
            }
        }

        public async Task<ProductsBySKUDTO> GetProductBySku(string sku)
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<ProductsBySKUDTO>($"Products/getproductbysku/{sku}");
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<ProductsDTO>> GetProducts()
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<ProductsDTO>>("Products/productdetails");
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<string[]> GetProductsAsSKU()
        {
            try
            {
                var list = new List<string>();
                var products = await GetProducts();
                list.AddRange(products.Select(x=> x.sku));
                return list.ToArray();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
