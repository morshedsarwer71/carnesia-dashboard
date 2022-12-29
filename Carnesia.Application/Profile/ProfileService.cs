using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;
using Newtonsoft.Json;
using Carnesia.Domain.Profile;

namespace Carnesia.Application.Profile
{
    public class ProfileService : IProfile
    {
        private readonly HttpClient _httpClient;
        public ProfileService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        //ChangePasswordDTO Password
        public async Task<bool> ChagePassword(ChangePasswordDTO password)
        {
            try
            {
                var response = await _httpClient.GetAsync($"Authentication/changepassword/{password.oldPassword}/{password.newPassword}");
                if (response.IsSuccessStatusCode) return true;
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Get Profile
        public async Task<ProfileDTO> GetProfile()
        {
            {
                try
                {
                    var response = await _httpClient.GetFromJsonAsync<ProfileDTO>("Authentication/get-user");
                    return response;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
