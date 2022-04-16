using Carnesia.Domain.Common.ResponseData;
using Carnesia.Domain.WMS.PO.Models;
using Carnesia.Domain.WMS.PO.ViewModels;
using ClosedXML.Excel;
using Newtonsoft.Json;
using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

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

        public async Task<MemoryStream> DownLoadExcel()
        {
            try
            {
                using (ExcelEngine excelEngine = new ExcelEngine())
                {
                    IApplication application = excelEngine.Excel;
                    application.DefaultVersion = ExcelVersion.Xlsx;

                    //Create a workbook.
                    IWorkbook workbook = application.Workbooks.Create(1);
                    IWorksheet worksheet = workbook.Worksheets[0];

                    //Initialize DataTable and data get from SampleDataTable method.
                    DataTable table = SampleDataTable();

                    //Export data from DataTable to Excel worksheet.
                    worksheet.ImportDataTable(table, true, 1, 1);

                    worksheet.UsedRange.AutofitColumns();

                    //Save the document as a stream and return the stream.
                    using (MemoryStream stream = new MemoryStream())
                    {
                        //Save the created Excel document to MemoryStream.
                        workbook.SaveAs(stream);
                        return stream;
                    }
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private DataTable SampleDataTable()
        {
            DataTable reports = new DataTable();

            reports.Columns.Add("SalesPerson");
            reports.Columns.Add("Age", typeof(int));
            reports.Columns.Add("Salary", typeof(int));

            reports.Rows.Add("Andy Bernard", 21, 30000);
            reports.Rows.Add("Jim Halpert", 25, 40000);
            reports.Rows.Add("Karen Fillippelli", 30, 50000);
            reports.Rows.Add("Phyllis Lapin", 34, 39000);
            reports.Rows.Add("Stanley Hudson", 45, 58000);

            return reports;
        }
    }
}
