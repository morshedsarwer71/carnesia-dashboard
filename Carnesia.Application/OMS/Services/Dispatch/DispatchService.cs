using Carnesia.Domain.OMS.AssignDelivery.Dispatch;
using Carnesia.Domain.OMS.PendingOrder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;
using Carnesia.Domain.OMS.PickPack;
using Microsoft.AspNetCore.Components.Forms;
using Carnesia.Domain.WMS.PO.Models;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System.Data;

namespace Carnesia.Application.OMS.Services.Dispatch
{
    public class DispatchService : IDispatch
    {
        private readonly HttpClient _httpClient;
        public DispatchService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<bool> AssignCourier(CreateDispatchDTO dispatchData)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("Oms/dispatch", dispatchData);

                if (result.IsSuccessStatusCode) return true;
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<PickPackDTO>> BulkDeliverOrder(InputFileChangeEventArgs e)
        {
            try
            {
                var errorsList = new List<PickPackDTO>();
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
                    var orderId = row.Field<string>("OrderID");
                    if (!String.IsNullOrEmpty(orderId))
                    {
                        var result = await ConfirmDispatch(orderId);

                        if (result.message != "Success")
                        {
                            errorsList.Add(result);
                        }
                    }
                }

                return errorsList;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<PickPackDTO> CancelDispatch(string orderId)
		{
			try
			{
                var result = await _httpClient.GetFromJsonAsync<PickPackDTO>($"Oms/returndelivery/{orderId}");

                return result;
			}
			catch (Exception)
			{

				throw;
			}
		}

		public async Task<PickPackDTO> ConfirmDispatch(string orderId)
		{
            try
            {
                var result = await _httpClient.GetFromJsonAsync<PickPackDTO>($"Oms/confirmdelivery/{orderId}");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

		public async Task<List<PendingOrderDTO>> GetDispatchedOrders()
		{
			try
			{
                var result = await _httpClient.GetFromJsonAsync<List<PendingOrderDTO>>("Oms/dispatchedorders");

                return result;
            }
			catch (Exception)
			{

				throw;
			}
		}

		public async Task<List<PendingOrderDTO>> GetOrders()
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<PendingOrderDTO>>("Oms/dispatchorders");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<PendingOrderDTO>> GetOrdersByFilter(DispatchFilterDTO filter)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("Oms/dispatchordersfilter", filter);

                var json = await result.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<List<PendingOrderDTO>>(json);
                return data;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
