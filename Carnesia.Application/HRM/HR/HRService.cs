using Carnesia.Domain.HRM.HR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace Carnesia.Application.HRM.HR
{
    public class HRService : IHR
    {
        private readonly HttpClient _httpClient;
        public HRService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<HRDepartmentsDTO>> GetDepartments()
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<HRDepartmentsDTO>>("hr/departments");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<HRDesignationsDTO>> GetDesignations()
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<HRDesignationsDTO>>("hr/designations");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
