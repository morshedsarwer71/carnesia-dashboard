using Carnesia.Domain.Common.ResponseData;
using Carnesia.Domain.WMS.PO.Models;
using Carnesia.Domain.WMS.PO.ViewModels;
using Microsoft.JSInterop;
using Newtonsoft.Json;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Forms;
using ClosedXML.Excel;

namespace Carnesia.Application.WMS.PO.Services
{
    public class PurchaseOrderService : IPurchaseOrder
    {
        private readonly HttpClient _httpClient;
        public PurchaseOrderService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<string> AddPurchaseOrder(PurchaseOrder purchaseOrder)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync("PurchaseOrders", purchaseOrder);
                //var result = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var deserialized = JsonConvert.DeserializeObject<Response>(json);
                    return deserialized.Message;
                }
                return "Failed";
            }
            catch (Exception)
            {
                return "Failed";
                throw;
            }
        }

        public async Task DownLoadExcel(IJSRuntime jSRuntime)
        {
            try
            {
                byte[] fileContents;
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                using(var package=new ExcelPackage())
                {
                    var workSheet = package.Workbook.Worksheets.Add("Sheet1");

                    #region Header Row
                    workSheet.Cells[1, 1].Value = "SKU";
                    workSheet.Cells[1, 1].Style.Font.Size = 12;
                    workSheet.Cells[1, 1].Style.Font.Bold = true;
                    workSheet.Cells[1, 1].Style.Border.Top.Style = ExcelBorderStyle.Hair;
                    
                    workSheet.Cells[1, 2].Value = "Quantity";
                    workSheet.Cells[1, 2].Style.Font.Size = 12;
                    workSheet.Cells[1, 2].Style.Font.Bold = true;
                    workSheet.Cells[1, 2].Style.Border.Top.Style = ExcelBorderStyle.Hair;
                    
                    workSheet.Cells[1, 3].Value = "Lifting Price";
                    workSheet.Cells[1, 3].Style.Font.Size = 12;
                    workSheet.Cells[1, 3].Style.Font.Bold = true;
                    workSheet.Cells[1, 3].Style.Border.Top.Style = ExcelBorderStyle.Hair;


                    #endregion
                    //
                    // #region Body 1st Row
                    // workSheet.Cells[2, 1].Value = "Sakib";
                    // workSheet.Cells[1, 1].Style.Border.Top.Style = ExcelBorderStyle.Hair;
                    // #endregion
                    fileContents = package.GetAsByteArray();
                }

                await jSRuntime.InvokeAsync<object>(
                        "saveAsFile",
                        "ProductList.xlsx",
                        Convert.ToBase64String(fileContents));

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<DataTable> UploadExcelFile(InputFileChangeEventArgs file)
        {
            try
            {
                DataTable dtTable = new DataTable();
                return dtTable;
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        // public async Task<List<PoProductDTO>> UploadExcelFile(IBrowserFile file)
        // {
        //     try
        //     {
        //         
        //         var list = new List<PoProductDTO>();
        //         using (MemoryStream stream=new MemoryStream())
        //         {
        //             
        //             await file.OpenReadStream(file.Size).CopyToAsync(stream);
        //             using (ExcelPackage package=new ExcelPackage(stream))
        //             {
        //                 ExcelWorksheet worksheet = package.Workbook.Worksheets.FirstOrDefault();
        //                 int colCount = worksheet.Dimension.End.Column;
        //                 int rowCount = worksheet.Dimension.End.Row;
        //                 PoProductDTO poProductDto = new PoProductDTO();
        //                 for (int row = 0; row <= rowCount; row++)
        //                 {
        //                     for (int col = 0; col < colCount; col++)
        //                     {
        //                         if (col == 1)
        //                         {
        //                             poProductDto.sku = worksheet.Cells[row, col].Value.ToString();
        //                         }
        //                         else if (col==2)
        //                         {
        //                             poProductDto.quantity = 10;
        //                         }
        //                         else if (col==3)
        //                         {
        //                             poProductDto.liftingPrice = 100;
        //                         }
        //                     }
        //                     list.Add(poProductDto);
        //                 }
        //             }
        //             
        //         }
        //
        //         return list;
        //     }
        //     catch (Exception e)
        //     {
        //         Console.WriteLine(e);
        //         throw;
        //     }
        // }
    }
}
