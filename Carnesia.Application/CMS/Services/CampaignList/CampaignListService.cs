using Carnesia.Domain.CMS.Campaign;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace Carnesia.Application.CMS.Services.CampaignList
{
    public class CampaignListService : ICampaignList
    {
        private readonly HttpClient _httpClient;
        public CampaignListService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<bool> AddCampaignBanner(AddCampaignBannerDTO banner)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("Campaign/campaignbanner", banner);

                if (result.IsSuccessStatusCode) return true;
                return false;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> DeleteBanner(int id)
        {
            try
            {
                var result = await _httpClient.DeleteAsync($"Campaign/DeleteCampaignBanner/{id}");

                if (result.IsSuccessStatusCode) return true;
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<CampaignBannerDTO>> GetCampaignBanners()
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<CampaignBannerDTO>>("Campaign/campaignbanner");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<CampaignDTO> GetCampaignByID(int id)
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<CampaignDTO>($"Campaign/{id}");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<CampaignDTO>> GetCampaigns()
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<CampaignDTO>>("Campaign/getcampaigns");
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> Publishtoggle(int CampaignId)
        {
            try
            {
                var result = await _httpClient.GetStringAsync($"Campaign/togglepublish/{CampaignId}");

                if (result == "Togglesd") return true;
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> ToggleBannerPublish(int id)
        {
            try
            {
                var result = await _httpClient.GetStringAsync($"Campaign/ToggleCampaigndBanner/{id}");

                if (result == "toggled") return true;
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> ToggleHomePlacement(int id)
        {
            try
            {
                var result = await _httpClient.GetStringAsync($"Campaign/togglehome/{id}");

                if (result == "Togglesd") return true;
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
