using Carnesia.Domain.Common.Customer;
using Microsoft.AspNetCore.Components.Forms;
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

namespace Carnesia.Application.Common.Service.Customer
{
    public class CustomerSertvice : ICustomer
    {
        private readonly HttpClient _httpClient;
        public CustomerSertvice (HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        //public async Task<List<CustomerInfoBulkUploadDTO>> GenerateCustomer(InputFileChangeEventArgs e)
        //{
        //    try
        //    {
        //        var Customers = new List<CustomerInfoBulkUploadDTO>();
        //        DataTable dt = new DataTable();
        //        var fileStream = e.File.OpenReadStream();
        //        var ms = new MemoryStream();
        //        await fileStream.CopyToAsync(ms);
        //        fileStream.Close();
        //        ms.Position = 0;
        //        ISheet sheet;
        //        var xsswb = new XSSFWorkbook(ms);
        //        sheet = xsswb.GetSheetAt(0);
        //        IRow hr = sheet.GetRow(0);
        //        var rl = new List<string>();
        //        int cc = hr.LastCellNum;
        //        for (int j = 0; j < cc; j++)
        //        {
        //            ICell cell = hr.GetCell(j);
        //            dt.Columns.Add(cell.ToString());
        //        }
        //        for (int j = (sheet.FirstRowNum + 1); j <= sheet.LastRowNum; j++)
        //        {
        //            var r = sheet.GetRow(j);
        //            for (int i = r.FirstCellNum; i < cc; i++)
        //            {
        //                rl.Add(r.GetCell(i).ToString());
        //            }
        //            if (rl.Count > 0)
        //            {
        //                dt.Rows.Add(rl.ToArray());
        //            }
        //            rl.Clear();
        //        }
        //        foreach (DataRow row in dt.Rows)
        //        {
        //            var sku = row.Field<string>("SKU");
        //            var discType = row.Field<string>("DiscountType");
        //            var stock = Convert.ToInt32(row.Field<string>("Stock"));
        //            var regularPrice = Convert.ToDecimal(row.Field<string>("RegularPrice"));
        //            var discAmount = Convert.ToDecimal(row.Field<string>("DiscountAmount"));

        //            var pop = new CustomerInfoBulkUploadDTO()
        //            {
        //                sku = sku,
        //                discType = discType,
        //                regularPrice = regularPrice,
        //                discAmount = discAmount,
        //                stock = stock
        //            };
        //            Console.WriteLine(pop);
        //            Products.Add(pop);
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}
    }
}
