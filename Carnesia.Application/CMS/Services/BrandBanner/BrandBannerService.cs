using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;
using Carnesia.Domain.CMS.BrandBanner;

namespace Carnesia.Application.CMS.Services.BrandBanner
{
    public class BrandBannerService : IBrandBanner
    {
        private readonly HttpClient _httpClient;
        public BrandBannerService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<bool> CreateBrandBanner(AddBrandBannerDTO banner)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("Brands/brandbanner", banner);

                if (result.IsSuccessStatusCode)
                {
                    return true;
                }

                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<BrandBannerDTO>> GetBrandBanners()
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<BrandBannerDTO>>("Brands/brandbanner");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
