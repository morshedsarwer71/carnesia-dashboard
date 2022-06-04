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
