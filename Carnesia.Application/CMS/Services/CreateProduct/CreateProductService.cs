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
        public async Task<string> CreateParentProduct(ParentProductDTO ParentProduct)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("ProductParent/createproductparent", ParentProduct);
                if (result.IsSuccessStatusCode)
                {
                    var parentID = await result.Content.ReadAsStringAsync();
                    return parentID;
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
