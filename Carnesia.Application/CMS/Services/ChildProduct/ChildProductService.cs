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
    }
}
