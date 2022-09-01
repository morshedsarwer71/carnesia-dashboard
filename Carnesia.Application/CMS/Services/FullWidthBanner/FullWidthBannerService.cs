using Carnesia.Domain.CMS.FullWidthBanner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace Carnesia.Application.CMS.Services.FullWidthBanner
{
    public class FullWidthBannerService : IFullWidthBanner
    {
        private readonly HttpClient _httpClient;
        public FullWidthBannerService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task CreateBanner(CreateFullWidthBannerDTO Banner)
        {
            try
            {
                await _httpClient.PostAsJsonAsync("FullWidthBanner/createfullwidthbanner", Banner);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task DeleteBanner(int id)
        {
            try
            {
                await _httpClient.DeleteAsync($"FullWidthBanner/deletefullwidthbanner/{id}");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<FullWidthBannerDTO>> GetBanners()
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<FullWidthBannerDTO>>("FullWidthBanner/getallfullwidthbanner");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> PublishToggle(int id)
        {
            try
            {
                var result = await _httpClient.GetAsync($"FullWidthBanner/togglepublish/{id}");

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
