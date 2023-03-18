using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;
using Carnesia.Domain.CMS.ProductList;
using Microsoft.AspNetCore.Components.Forms;
using Carnesia.Domain.CMS.ChildProduct;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System.Data;

namespace Carnesia.Application.CMS.Services.ProductList
{
    public class ProductListService : IProductList
    {
        private readonly HttpClient _httpClient;
        public ProductListService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<bool> ApproveProduct(int id)
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<bool>($"Products/approveprice/{id}");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> DeleteProduct(int id)
        {
            try
            {
                var result = await _httpClient.DeleteAsync($"Products/deleteproduct/{id}");

                return result.IsSuccessStatusCode;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<ProductQuickSettingDTO>> GetAllProducts()
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<ProductQuickSettingDTO>>("Products/productlist");
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<ProductQuickSettingDTO>> GetAllUnapprovedProducts()
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<ProductQuickSettingDTO>>("Products/approvepriceproducts");
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<ProductListDTO>> GetProducts()
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<ProductListDTO>>("Products/productdetails");
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<ProductListV2DTO>> GetProductsBySearchV2(ProductListFilterV2DTO Filter)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("Products/productlists", Filter);

                var json = await result.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<List<ProductListV2DTO>>(json);

                return data;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<ProductListV2DTO>> GetProductsForDownloadV2()
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<ProductListV2DTO>>("Products/productlists");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<ProductListV2DTO>> GetProductsV2(int prev, int next)
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<ProductListV2DTO>>($"Products/productlists/{prev}/{next}");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> PublishBulkProducts(List<ProductBulkPublishDTO> products)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("Products/bulkpublish", products);

                return result.IsSuccessStatusCode;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> QuickSetting(ProductQuickSettingUpdateDTO product)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("Products/quickproduct", product);

                if (result.IsSuccessStatusCode) return true;
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<ProductBulkPublishDTO>> UploadXLSXFileForCategory(InputFileChangeEventArgs e)
        {
            try
            {
                var Products = new List<ProductBulkPublishDTO>();
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

                    var productCode = row.Field<string>("ProductCode");
                    var productSku = row.Field<string>("ProductSku");
                    var isPublish = Convert.ToInt32(row.Field<string>("IsPublish"));

                    var pop = new ProductBulkPublishDTO()
                    {
                        productCode = productCode,
                        productSku = productSku,
                        isPublish = isPublish,
                    };
                    Products.Add(pop);
                }
                return Products.Where(x => x.productCode != null).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
