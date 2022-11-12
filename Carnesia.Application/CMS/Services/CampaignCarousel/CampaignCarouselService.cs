using Carnesia.Domain.CMS.CampaignCarousel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace Carnesia.Application.CMS.Services.CampaignCarousel
{
    public class CampaignCarouselService : ICampaignCarousel
    {
        private readonly HttpClient _httpClient;
        public CampaignCarouselService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<bool> CreateCarousel(CampaignCarouselDTO carousel)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("CampaignLanding/campaigncarousel", carousel);

                if (result.IsSuccessStatusCode) return true;
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public async Task<bool> DeleteCarousel(int id)
        {
            try
            {
                var result = await _httpClient.DeleteAsync($"CampaignLanding/campaigncarousel/delete/{id}");

                if (result.IsSuccessStatusCode) return true;

                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<CampaignCarouselDTO>> GetAllCarousels()
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<CampaignCarouselDTO>>("CampaignLanding/campaigncarousel");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task ToggleCarousel(int id)
        {
            try
            {
                await _httpClient.GetAsync($"CampaignLanding/campaigncarousel/toggle/{id}");
                //var json = await result.Content.ReadAsStringAsync();
                //var data = JsonConvert.DeserializeObject<string>(json);
                //Console.WriteLine(result);
                //return result;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
