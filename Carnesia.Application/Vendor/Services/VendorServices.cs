using Carnesia.Domain.Vendor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;

namespace Carnesia.Application.Vendor.Services
{
    public class VendorServices : IVendor
    {
        private readonly HttpClient _httpClient;
        public VendorServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<VendorDTO> GetVendor(string vendorName)
        {
            try
            {
                var vendors = await GetVendorsAsync();
                return vendors.FirstOrDefault(x => x.name == vendorName);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<string[]> GetVendorsNameAsString()
        {
            try
            {
                var list = new List<string>();
                var vendors = await GetVendorsAsync();
                list.AddRange(vendors.Select(x=>x.name));
                return list.ToArray();

            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<VendorDTO>> GetVendorsAsync()
        {
            try
            {
                var response = await _httpClient.GetFromJsonAsync<IEnumerable<VendorDTO>>("Vendors");
                return response;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
