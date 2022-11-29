using Carnesia.Domain.CMS.CampaignSection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace Carnesia.Application.CMS.Services.CampaignSection
{
    public class CampaignSectionService : ICampaignSection
    {
        private readonly HttpClient _httpClient;
        public CampaignSectionService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<bool> CreateNewCampaignBunch(CampaignSectionDTO section)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("CampaignLanding/campaignsection", section);

                if (result.IsSuccessStatusCode) return true;
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<CampaignSectionDTO>> GetAllSections()
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<CampaignSectionDTO>>("CampaignLanding/campaignsection");
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<CampaignSectionThumbsDTO> GetThumbById(int id)
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<CampaignSectionThumbsDTO>($"CampaignLanding/campaignsection/thumb/{id}");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> UpdateThumb(CampaignSectionThumbsDTO thumb)
        {
            try
            {
                var result = await _httpClient.PutAsJsonAsync($"CampaignLanding/campaignsection/thumb/{thumb.id}", thumb);

                return result.IsSuccessStatusCode;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
