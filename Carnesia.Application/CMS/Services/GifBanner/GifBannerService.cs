using Carnesia.Domain.CMS.GifBanner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;
using Newtonsoft.Json;

namespace Carnesia.Application.CMS.Services.GifBanner
{
    public class GifBannerService : IGifBanner
    {
        private readonly HttpClient _httpClient;
        public GifBannerService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task AddGifBanner(AddGifBannerDTO Banner)
        {
            try
            {
                await _httpClient.PostAsJsonAsync("HomePage/gifbanner", Banner);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<GifBannerDTO>> GetGifBanners()
        {
            try
            {
                var Banners = await _httpClient.GetFromJsonAsync<List<GifBannerDTO>>("HomePage/getallgifbanner");

                return Banners;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task RemoveBanner(int BannerId)
        {
            try
            {
                await _httpClient.DeleteAsync($"HomePage/deletegifbanner/{BannerId}");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> ToggleGifBanner(int id)
        {
            try
            {
                var result = await _httpClient.PostAsync($"HomePage/Togglepublishgifbanner/{id}", null);
                if(result.IsSuccessStatusCode) return true;
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
