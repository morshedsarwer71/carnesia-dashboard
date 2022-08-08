using Carnesia.Domain.CMS.UnderCarouselBanner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;


namespace Carnesia.Application.CMS.Services.UnderCarouselBanner
{
    public class UnderCarouselBannerService : IUnderCarouselBanner
    {
        private readonly HttpClient _httpClient;
        public UnderCarouselBannerService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<UnderCarouselBannerDTO>> GetAllBanners()
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<UnderCarouselBannerDTO>>("HomePage/getallbanners");
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
                var result = await _httpClient.PostAsync($"HomePage/ToggleBannerPublish/{id}", null);

                if (result.IsSuccessStatusCode) return true;
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task AddBanner(AddUnderCarouselBannerDTO Banner)
        {
            try
            {
                await _httpClient.PostAsJsonAsync("Homepage/banner", Banner);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task DeleteBanner(int BannerId)
        {
            try
            {
                await _httpClient.DeleteAsync($"HomePage/DeleteBanner/{BannerId}");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
