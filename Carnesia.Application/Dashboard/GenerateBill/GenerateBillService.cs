using Carnesia.Domain.Dashboard.GenerateBill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;


namespace Carnesia.Application.Dashboard.GenerateBill
{
    public class GenerateBillService : IGenerateBill
    {
        private readonly HttpClient _httpClient;
        public GenerateBillService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<GenerateBillCustomerInfoDTO> GetCustomerInfo(string phoneOrId)
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<GenerateBillCustomerInfoDTO>($"Pos/getcustomer/{phoneOrId}");
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<decimal> GetDiscount(string code, decimal subTotal)
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<decimal>($"Pos/storevoucher/{code}/{subTotal}");
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<GenerateBillUIDDataDTO> GetProductByUid(string uid)
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<GenerateBillUIDDataDTO>($"Pos/getuiddetails/{uid}");
                return result;

            }
            catch (Exception e)
            {
                //Console.WriteLine(e.Message);
                throw;
            }
        }

        public async Task<bool> NewPOS(GenerateBillPOSDTO pos)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("Pos", pos);

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
