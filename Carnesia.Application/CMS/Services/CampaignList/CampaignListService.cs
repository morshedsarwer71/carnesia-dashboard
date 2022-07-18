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

        public async Task Publishtoggle(int CampaignId)
        {
            try
            {
                await _httpClient.PostAsync($"Campaign/togglepublish/{CampaignId}", null);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
