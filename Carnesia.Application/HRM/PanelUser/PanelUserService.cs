using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;
using Carnesia.Domain.HRM.PanelUser;

namespace Carnesia.Application.HRM.PanelUser
{
    public class PanelUserService : IPanelUser
    {
        private readonly HttpClient _httpClient;
        public PanelUserService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<string[]> GetRoles()
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<string[]>("Authentication/getallroles");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<PanelUserListDTO>> GetUsers()
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<PanelUserListDTO>>("Authentication/system-users");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> NewPanelUser(PanelUserDTO user)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync($"Authentication/system-user", user);

                if (result.IsSuccessStatusCode) return true;
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> ToggleUser(string id)
        {
            try
            {
                var result = await _httpClient.GetAsync($"Authentication/diableuser/{id}");
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
