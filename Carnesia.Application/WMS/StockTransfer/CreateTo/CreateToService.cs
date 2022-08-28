using Carnesia.Domain.WMS.TO.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components.Forms;
using System.Data;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using Newtonsoft.Json;

namespace Carnesia.Application.WMS.StockTransfer.CreateTo
{
    public class CreateToService : ICreateTo
    {
        private readonly HttpClient _httpClient;
        public CreateToService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<CreateToProductPoco>> GetBulkProducts(int source, int destination, InputFileChangeEventArgs e)
        {
            try
            {
                var products = new List<CreateToProductPoco>();
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
                    var sku = row.Field<string>("sku");
                    var inputQTY = Convert.ToInt32(row.Field<string>("trnQty"));

                    var result = await GetProduct(source, destination, sku);

                    if (result != null)
                    {
                        bool isThere = products.Any(x => x.productCode == result.data.productCode);
                        if (isThere)
                        {
                            int pIndex = products.FindIndex(x => x.productCode == result.data.productCode);
                            products[pIndex].quantity += inputQTY;
                        }
                        else
                        {
                            result.data.quantity = inputQTY;
                            products.Add(result.data);
                        }
                    }
                }

                return products;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<GetProductCreateToPoco> GetProduct(int source, int destination, string sku)
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<GetProductCreateToPoco>($"StockTransfers/getstockproduct/{source}/{destination}/{sku}");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<GetProductCreateToPoco> NewTo(NewToPoco to)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("StockTransfers", to);
                var json = await result.Content.ReadAsStringAsync();
                var content = JsonConvert.DeserializeObject<GetProductCreateToPoco>(json);
                return content;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
