using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;
using Carnesia.Domain.CMS.BunchProduct;

namespace Carnesia.Application.CMS.Services.BunchProduct
{
    public class BunchProductService : IBunchProduct
    {
        private readonly HttpClient _httpClient;
        public BunchProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<bool> AddNewProduct(AddBunchProductProductsDTO product)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("BunchProducts/addbunchproducttags", product);

                if (result.IsSuccessStatusCode) return true;

                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> CreateBunchProduct(AddBunchProductDTO bunch)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("BunchProducts", bunch);

                if (result.IsSuccessStatusCode) return true;

                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

		public async Task<bool> DeleteBunch(int id)
		{
			try
			{
                var result = await _httpClient.DeleteAsync($"BunchProducts?id={id}");

                if (result.IsSuccessStatusCode) return true;
                return false;
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
                var result = await _httpClient.DeleteAsync($"BunchProducts/deletebunchproducttag/{id}");

                if (result.IsSuccessStatusCode) return true;
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<SingleBunchProductDTO> GetBunchById(int id)
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<SingleBunchProductDTO>>($"BunchProducts/{id}");

                return result.Take(1).FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<BunchProductDTO>> GetBunchProducts()
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<BunchProductDTO>>("BunchProducts");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> UpdateBunch(SingleBunchProductDTO bunch)
        {
            try
            {
                var result = await _httpClient.PutAsJsonAsync($"BunchProducts/{bunch.id}", bunch);

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
