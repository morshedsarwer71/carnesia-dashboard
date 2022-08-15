using Carnesia.Domain.HRM.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace Carnesia.Application.HRM.User
{
    public class UserService : IUser
    {
        private readonly HttpClient _httpClient;
        public UserService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<UsersDTO> GetUserByConcat(string user)
        {
            try
            {
                var result = await GetUsers();
                return result.FirstOrDefault(x => x.concat == user);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<List<UsersDTO>> GetUsers()
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<UsersDTO>>("Authentication/customers");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<string[]> GetUsersAsString()
        {
            var list = new List<string>();
            var results = await GetUsers();
            list.AddRange(results.Select(x => x.concat));
            return list.ToArray();
        }
    }
}
