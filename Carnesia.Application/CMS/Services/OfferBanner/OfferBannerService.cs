using Carnesia.Domain.CMS.OfferBanner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace Carnesia.Application.CMS.Services.OfferBanner
{
    public class OfferBannerService : IOfferBanner
    {
        private readonly HttpClient _httpClient;
        public OfferBannerService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<bool> CreateNewBanner(string url, AddOfferBannerDTO banner)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync(url, banner);

                if (result.IsSuccessStatusCode) return true;
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<OfferBannerDTO>> GetPfferBanners(string url)
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<OfferBannerDTO>>(url);
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> ToggleBanner(string url, int id)
        {
            try
            {
                var result = await _httpClient.PostAsync(url+id, null);

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
