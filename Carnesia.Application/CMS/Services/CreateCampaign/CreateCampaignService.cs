using Carnesia.Domain.CMS.Campaign;
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
using Carnesia.Domain.WMS.PO.Models;

namespace Carnesia.Application.CMS.Services.CreateCampaign
{
    public class CreateCampaignService : ICreateCampaign
    {
        private readonly HttpClient _httpClient;
        public CreateCampaignService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<bool> AddProductToCampaign(AddCampaignProductDTO Product)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("Campaign/AddCampaignProduct", Product);

                if (result.IsSuccessStatusCode)
                {
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public async Task<bool> CreateCampaign(AddCampaignDTO Campaign)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("Campaign", Campaign);

                if (result.IsSuccessStatusCode) return true;
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> DeleteCampaignProduct(int id)
        {
            try
            {
                var result = await _httpClient.DeleteAsync($"Campaign/deleteCampaignProduct/{id}");
                if (result.IsSuccessStatusCode)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> ProductBulkUpdate(List<CampaignProductUpdateDTO> products, string code)
        {
            try
            {
                var result = await _httpClient.PutAsJsonAsync($"Campaign/bulkproductupdate/{code}", products);

                return result.IsSuccessStatusCode;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> UpdateCampaignDetails(AddCampaignDetailsDTO Campaign, int id)
        {
            try
            {
                var result = await _httpClient.PutAsJsonAsync($"Campaign/{id}", Campaign);

                if (result.IsSuccessStatusCode)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> UpdateCampaignProduct(CampaignProductUpdateDTO product, int id)
        {
            try
            {
                var result = await _httpClient.PutAsJsonAsync($"Campaign/updateCampaignProduct/{id}", product);

                if (result.IsSuccessStatusCode) return true;
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public async Task<List<CampaignProductUpdateDTO>> UploadProductUpdateExcelFile(InputFileChangeEventArgs e)
        {
            try
            {
                var Products = new List<CampaignProductUpdateDTO>();
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
                    var productId = Convert.ToInt32(row.Field<string>("Id"));
                    var productSku = row.Field<string>("ProductSKU");
                    var productName = row.Field<string>("ProductName");
                    var discType = row.Field<string>("DiscType");
                    var discAmount = Convert.ToDecimal(row.Field<string>("DiscAmount"));
                    var stock = Convert.ToInt32(row.Field<string>("Stock"));
                    var maxOrderQty = Convert.ToInt32(row.Field<string>("MaxOrder"));


                        var pop = new CampaignProductUpdateDTO()
                        {
                            productId = productId,
                            discAmount= discAmount,
                            discType = discType,
                            stock= stock,
                            maxOrderQty=maxOrderQty,
                        };
                        Products.Add(pop);
                    
                }

                return Products;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<List<AddCampaignProductDTO>> UploadXLSXFile(InputFileChangeEventArgs e)
        {
            try
            {
                var Products = new List<AddCampaignProductDTO>();
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
                    var sku = row.Field<string>("SKU");
                    var discType = row.Field<string>("DiscountType");
                    var stock = Convert.ToInt32(row.Field<string>("Stock"));
                    var maxOrderQty = Convert.ToInt32(row.Field<string>("MaxBuy"));
                    var regularPrice = Convert.ToDecimal(row.Field<string>("RegularPrice"));
                    var discAmount = Convert.ToDecimal(row.Field<string>("DiscountAmount"));

                    var pop = new AddCampaignProductDTO()
                    {
                        sku = sku,
                        discType = discType,
                        regularPrice = regularPrice,
                        discAmount = discAmount,
                        stock = stock,
                        maxOrderQty = maxOrderQty
                    };
                    Console.WriteLine(pop);
                    Products.Add(pop);
                }
                return Products.Where(x => x.sku != null).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
