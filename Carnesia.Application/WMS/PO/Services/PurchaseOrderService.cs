using Carnesia.Domain.Common.ResponseData;
using Carnesia.Domain.WMS.PO.Models;
using Carnesia.Domain.WMS.PO.ViewModels;
using Microsoft.JSInterop;
using Newtonsoft.Json;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.Data;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Application.CMS.Services;
using Carnesia.Domain.WMS.PO.Models.Awaiting;
using Carnesia.Domain.WMS.PO.POCO;
using Carnesia.Domain.WMS.PO.ViewModels.Awaiting;
using Microsoft.AspNetCore.Components.Forms;
using ClosedXML.Excel;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.XSSF.UserModel;
using Carnesia.Domain.WMS.TrackUID;
using System.Drawing;
using System.Drawing.Printing;

namespace Carnesia.Application.WMS.PO.Services
{
    public class PurchaseOrderService : IPurchaseOrder
    {
        private readonly HttpClient _httpClient;
        private readonly IProduct _product;
        public PurchaseOrderService(HttpClient httpClient,IProduct product)
        {
            _httpClient = httpClient;
            _product = product;
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
                return "Po creation failed";
            }
            catch (Exception)
            {
                return "Po creation failed";
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
                    
                    workSheet.Cells[1, 3].Value = "LiftingPrice";
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
                        "PoProducts.xlsx",
                        Convert.ToBase64String(fileContents));

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<PoProductDTO>> UploadExcelFile(InputFileChangeEventArgs e)
        {
            try
            {
                var poProducts = new List<PoProductDTO>();
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
                for (int j = (sheet.FirstRowNum+1); j <= sheet.LastRowNum; j++)
                {
                    var r = sheet.GetRow(j);
                    for (int i = r.FirstCellNum; i < cc; i++)
                    {
                        rl.Add(r.GetCell(i).ToString());
                    }
                    if (rl.Count>0)
                    {
                        dt.Rows.Add(rl.ToArray());
                    }
                    rl.Clear();
                }
                
                foreach (DataRow row in dt.Rows)
                {
                    var sku = row.Field<string>("SKU");
                    var qty = Convert.ToInt32(row.Field<string>("Quantity"));
                    var price=Convert.ToDecimal(row.Field<string>("LiftingPrice"));
                    var total = qty * price;
                    var skuProduct = await _product.GetProducBySku(sku);
                    if (skuProduct!=null)
                    {
                        var pop = new PoProductDTO()
                        {
                            sku = sku,
                            quantity = qty,
                            liftingPrice = price,
                            TotalPrice = total,
                            productName = skuProduct.productName
                        };
                        poProducts.Add(pop);
                    }
                }

                return poProducts.Where(x => x.productName != null).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<PoProductDTO> AddProduct(PoProductDTO poProductDto)
        {
            try
            {
                    var skuProduct = await _product.GetProducBySku(poProductDto.sku);
                    if (skuProduct == null) return null;
                    var total = poProductDto.liftingPrice * poProductDto.quantity;
                    var poProd = new PoProductDTO()
                    {
                        liftingPrice = poProductDto.liftingPrice,
                        productName = skuProduct.productName,
                        quantity = poProductDto.quantity,
                        sku = skuProduct.productsku,
                        TotalPrice = total,
                        productCode = skuProduct.productCode
                    };
                    return poProd;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<List<AwaitingPo>> AwaitingPo()
        {
            try
            {
                var orders = await _httpClient.GetFromJsonAsync<List<AwaitingPo>>("PurchaseOrders/awaitingapprovalpo");
                return orders;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<List<AwaitingPo>> AwaitingPoByPoCode(string poCode)
        {
            try
            {
                var order = await _httpClient.GetFromJsonAsync<List<AwaitingPo>>(
                    $"PurchaseOrders/awaitingapprovalpobycode/{poCode}");
                return order;
            }
            catch (Exception )
            {
                throw;
            }
        }

        public async Task<Response> PoApprove(string poCode)
        {
            try
            {
                var res = await _httpClient.GetFromJsonAsync<Response>($"PurchaseOrders/poapprove/{poCode}");
                return res;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<AwaitingPoDetails> AwaitingPoDetails(string poCode)
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<AwaitingPoDetails>($"PurchaseOrders/podetails/{poCode}");
                
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<List<POListPoco>> GetPoList()
        {
            try
            {
                var poList = await _httpClient.GetFromJsonAsync<List<POListPoco>>("PurchaseOrders/approvedpo");
                return poList;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<string> RemoveSelectedItems(string poCode, List<PoProductDTO> poProducts)
        {
            try
            {
                var result = await _httpClient.PutAsJsonAsync($"PurchaseOrders/removeseleteditems/{poCode}", poProducts);
                if (result.IsSuccessStatusCode)
                {
                    return "success";
                }
                else
                {
                    return "failed";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<string> ApproveSelectedItems(string poCode, List<PoProductDTO> poProducts)
        {
            try
            {
                var result = await _httpClient.PutAsJsonAsync($"PurchaseOrders/approveselecteditems/{poCode}", poProducts);
                if (result.IsSuccessStatusCode)
                {
                    return "success";
                }
                else
                {
                    return "failed";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<string> GenerateUID(UIDPoco form)
        {
            try
            {
                
                var res = await _httpClient.PostAsJsonAsync("PurchaseOrders/generateuid", form);
                if (res.IsSuccessStatusCode)
                {
                    var json = await res.Content.ReadAsStringAsync();
                    var deserialized = JsonConvert.DeserializeObject<Response>(json);
                    return deserialized.Message;
                }
                return null;
            }
            catch (Exception)
            {
                throw;

               //return null;
            }
        }

        public async Task TestPrint()
        {
            try
            {
                var printFont = new Font("Arial", 15);
                var sr = new StreamReader(@"MyFileToPrint.txt");
                //PrintDialog printDlg = new PrintDialog();
                PrintDocument printDoc = new PrintDocument();
                printDoc.Print();
                
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
