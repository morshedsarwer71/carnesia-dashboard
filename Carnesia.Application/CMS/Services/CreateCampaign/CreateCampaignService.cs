using Carnesia.Domain.CMS.Campaign;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace Carnesia.Application.CMS.Services.CreateCampaign
{
    public class CreateCampaignService : ICreateCampaign
    {
        private readonly HttpClient _httpClient;
        public CreateCampaignService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task CreateCampaign(AddCampaignDTO Campaign)
        {
            try
            {
                await _httpClient.PostAsJsonAsync("Campaign", Campaign);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
