using Carnesia.Domain.CMS.ParentProduct;
using Carnesia.Domain.CMS.SimpleProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components.Forms;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.Data;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.XSSF.UserModel;

namespace Carnesia.Application.CMS.Services.ParentProduct
{
    public class ParentProductService : IParentProduct
    {
        private readonly HttpClient _httpClient;
        public ParentProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<CreateParentProductDTO>> CreateBulkParents(List<CreateParentProductDTO> Parents)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync<List<CreateParentProductDTO>>("ProductParent/bulk", Parents);

                if (result.IsSuccessStatusCode)
                {
                    var json = await result.Content.ReadAsStringAsync();
                    var deserialized = JsonConvert.DeserializeObject<List<CreateParentProductDTO>>(json);
                    return deserialized;
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task CreateParentProduct(CreateParentProductDTO ParentProduct)
        {
            try
            {
                await _httpClient.PostAsJsonAsync("ProductParent", ParentProduct);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<string> CreateParentProductReturnID(SimpleProductParentDTO ParentProduct)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("ProductParent", ParentProduct);
                if (result.IsSuccessStatusCode)
                {
                    var parentId = await result.Content.ReadAsStringAsync();
                    return parentId;
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<string[]> GetParentProductAsString()
        {
                var list = new List<string>();
                var products = await GetParentProducts();
                list.AddRange(products.Select(x => x.name));
                return list.ToArray();
        }

        public async Task<int> GetParentProductID(string ProductName)
        {
            try
            {
                var products = await GetParentProducts();
                return products.FirstOrDefault(x => x.name == ProductName).id;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<ParentProductDTO>> GetParentProducts()
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<ParentProductDTO>>("ProductParent/getcompoundproductparent");
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> UpdateParentProduct(ParentProductDTO ParentProduct)
        {
            try
            {
                var result = await _httpClient.PutAsJsonAsync($"ProductParent/{ParentProduct.id}", ParentProduct);
                if (result.IsSuccessStatusCode) return true;
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public async Task<List<CreateParentProductDTO>> UploadXLSXFile(InputFileChangeEventArgs e)
        {
            try
            {
                var Products = new List<CreateParentProductDTO>();
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
                    var name = row.Field<string>("ProductName");
                    var originId = row.Field<string>("Origin");
                    var productType = row.Field<string>("ProductType");
                    var brandId = Convert.ToInt32(row.Field<string>("BrandID"));

                    var pop = new CreateParentProductDTO()
                    {
                        name = name,
                        originId = originId,
                        productType = productType,
                        brandId = brandId
                    };
                    Products.Add(pop);
                }
                return Products.Where(x => x.name != null).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
