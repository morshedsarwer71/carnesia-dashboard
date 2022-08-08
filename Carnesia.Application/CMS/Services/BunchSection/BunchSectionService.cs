using Carnesia.Domain.CMS.BunchSection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace Carnesia.Application.CMS.Services.BunchSection
{
    public class BunchSectionService : IBunchSection
    {
        private readonly HttpClient _httpClient;
        public BunchSectionService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<bool> CreateNewBunchSection(NewBunchSectionDTO bunch)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("HomeBunch/createhomebunch", bunch);

                if (result.IsSuccessStatusCode) return true;
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> DeleteBunchSection(int id)
        {
            try
            {
                var result = await _httpClient.DeleteAsync($"HomeBunch/deletehomebunch/{id}");

                if (result.IsSuccessStatusCode) return true;
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<BunchSectionListDTO>> GetAllBunchSections()
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<BunchSectionListDTO>>("HomeBunch/getallhomebunch");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
