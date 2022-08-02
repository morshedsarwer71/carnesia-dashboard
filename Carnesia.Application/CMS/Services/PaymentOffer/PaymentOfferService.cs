using Carnesia.Domain.CMS.PaymentOffer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace Carnesia.Application.CMS.Services.PaymentOffer
{
    public class PaymentOfferService : IPaymentOffer
    {
        private readonly HttpClient _httpClient;
        public PaymentOfferService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<bool> CreateNewOffer(string apiURL, AddTextDTO offer)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync(apiURL, offer);

                if(result.IsSuccessStatusCode) return true;
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Task<List<SideTextDTO>> GetSideTexts(string apiURL)
        {
            try
            {
                var result = _httpClient.GetFromJsonAsync<List<SideTextDTO>>(apiURL+"s");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> ToggleSideText(string apiURL, int id)
        {
            try
            {
                var result = await _httpClient.GetStringAsync(apiURL+id);

                if (result == "Toggled") return true;
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}