using Carnesia.Domain.Vendor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;
using Carnesia.Domain.Vendor.POCO;
using Microsoft.AspNetCore.Components.Forms;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.Data;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.XSSF.UserModel;
using Newtonsoft.Json;

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

        public async Task<bool> AddVendor(PostVendorPoco vendorPoco)
        {
            try
            {
                var res = await _httpClient.PostAsJsonAsync("Vendors", vendorPoco);
                if (res.IsSuccessStatusCode)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public async Task<bool> UpdateVendor(VendorDTO vendor)
        {
            try
            {
                var result = await _httpClient.PutAsJsonAsync($"Vendors/update/{vendor.vendorId}", vendor);

                if (result.IsSuccessStatusCode) return true;

                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<PostVendorPoco>> UploadXLSXFile(InputFileChangeEventArgs e)
        {
            try
            {
                var Vendors = new List<PostVendorPoco>();
                DataTable dt = new DataTable();
                var fileStream = e.File.OpenReadStream();
                var ms = new MemoryStream();
                await fileStream.CopyToAsync(ms);
                fileStream.Close();
                ms.Position = 0;
                ISheet sheet;
                var xsswb = new XSSFWorkbook(ms);
                sheet = xsswb.GetSheetAt(0);
                IRow hr = sheet.GetRow(0);
                var rl = new List<string>();
                int cc = hr.LastCellNum;
                for (int j = 0; j < cc; j++)
                {
                    ICell cell = hr.GetCell(j);
                    dt.Columns.Add(cell.ToString());
                }
                for (int j = (sheet.FirstRowNum + 1); j <= sheet.LastRowNum; j++)
                {
                    var r = sheet.GetRow(j);
                    for (int i = r.FirstCellNum; i < cc; i++)
                    {
                        rl.Add(r.GetCell(i).ToString());
                    }
                    if (rl.Count > 0)
                    {
                        dt.Rows.Add(rl.ToArray());
                    }
                    rl.Clear();
                }
                foreach (DataRow row in dt.Rows)
                {
                    var name = row.Field<string>("Name");
                    var owner = row.Field<string>("Owner");
                    var importer = row.Field<string>("Importer");
                    var initial = row.Field<string>("Initial");
                    var bankAccountDetails = row.Field<string>("BankAccountDetails");
                    var managerName = row.Field<string>("ManagerName");
                    var phoneNumber = row.Field<string>("PhoneNumber");
                    var addressOne = row.Field<string>("AddressOne");
                    var addressTwo = row.Field<string>("AddressTwo");

                    var pop = new PostVendorPoco()
                    {
                        name = name,
                        bankAccountDetails = bankAccountDetails,
                        addressOne = addressOne,
                        addressTwo = addressTwo,
                        phoneNumber = phoneNumber,
                        importer = importer,
                        initial = initial,
                        managerName = managerName,
                        owner = owner,
                    };
                    Vendors.Add(pop);
                }
                return Vendors.Where(x => x.name != null).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<PostVendorPoco>> CreateBulkVendors(List<PostVendorPoco> Vendors)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync<List<PostVendorPoco>>("Vendors/bulk", Vendors);

                if (result.IsSuccessStatusCode)
                {
                    var json = await result.Content.ReadAsStringAsync();
                    var deserialized = JsonConvert.DeserializeObject<List<PostVendorPoco>>(json);
                    return deserialized; 
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
