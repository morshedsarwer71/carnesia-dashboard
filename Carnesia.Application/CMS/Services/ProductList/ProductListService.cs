using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;
using Carnesia.Domain.CMS.ProductList;

namespace Carnesia.Application.CMS.Services.ProductList
{
    public class ProductListService : IProductList
    {
        private readonly HttpClient _httpClient;
        public ProductListService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<bool> ApproveProduct(int id)
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<bool>($"Products/approveprice/{id}");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> DeleteProduct(int id)
        {
            try
            {
                var result = await _httpClient.DeleteAsync($"Products/deleteproduct/{id}");

                return result.IsSuccessStatusCode;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<ProductQuickSettingDTO>> GetAllProducts()
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<ProductQuickSettingDTO>>("Products/productlist");
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<ProductQuickSettingDTO>> GetAllUnapprovedProducts()
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<ProductQuickSettingDTO>>("Products/approvepriceproducts");
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<ProductListDTO>> GetProducts()
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<ProductListDTO>>("Products/productdetails");
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<ProductListV2DTO>> GetProductsBySearchV2(ProductListFilterV2DTO Filter)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("Products/productlists", Filter);

                var json = await result.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<List<ProductListV2DTO>>(json);

                return data;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<ProductListV2DTO>> GetProductsForDownloadV2()
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<ProductListV2DTO>>("Products/productlists");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<ProductListV2DTO>> GetProductsV2(int prev, int next)
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<ProductListV2DTO>>($"Products/productlists/{prev}/{next}");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> QuickSetting(ProductQuickSettingUpdateDTO product)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("Products/quickproduct", product);

                if (result.IsSuccessStatusCode) return true;
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
