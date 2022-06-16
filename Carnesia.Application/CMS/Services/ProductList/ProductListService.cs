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
    }
}
