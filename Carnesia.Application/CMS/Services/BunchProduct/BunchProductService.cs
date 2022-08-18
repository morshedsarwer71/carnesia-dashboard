using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;
using Carnesia.Domain.CMS.BunchProduct;
using Microsoft.AspNetCore.Components.Forms;
using NPOI.XSSF.UserModel;
using NPOI.SS.UserModel;
using System.Data;
using NPOI.SS.Util;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using Carnesia.Application.CMS.Services.Products;

namespace Carnesia.Application.CMS.Services.BunchProduct
{
    public class BunchProductService : IBunchProduct
    {
        private readonly HttpClient _httpClient;
        private readonly IProducts _products;
        public BunchProductService(HttpClient httpClient, IProducts products)
        {
            _httpClient = httpClient;
            _products = products;
        }

        //public BunchProductService()
        //{
           
        //}

        public async Task<bool> AddNewProduct(AddBunchProductProductsDTO product)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("BunchProducts/addbunchproducttags", product);

                if (result.IsSuccessStatusCode) return true;

                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> CreateBunchProduct(AddBunchProductDTO bunch)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("BunchProducts", bunch);

                if (result.IsSuccessStatusCode) return true;

                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

		public async Task<bool> DeleteBunch(int id)
		{
			try
			{
                var result = await _httpClient.DeleteAsync($"BunchProducts?id={id}");

                if (result.IsSuccessStatusCode) return true;
                return false;
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
                var result = await _httpClient.DeleteAsync($"BunchProducts/deletebunchproducttag/{id}");

                if (result.IsSuccessStatusCode) return true;
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<SingleBunchProductDTO> GetBunchById(int id)
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<SingleBunchProductDTO>($"BunchProducts/{id}");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<BunchProductDTO>> GetBunchProducts()
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<BunchProductDTO>>("BunchProducts");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> UpdateBunch(SingleBunchProductDTO bunch)
        {
            try
            {
                var result = await _httpClient.PutAsJsonAsync($"BunchProducts/{bunch.id}", bunch);

                if (result.IsSuccessStatusCode) return true;
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<List<AddBunchProductProductsDTO>> UploadXLSXFile(InputFileChangeEventArgs e)
        {
            try
            {
                var Products = new List<AddBunchProductProductsDTO>();
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

                    int result = await _products.GetProductIdBySku(sku);

                    var pop = new AddBunchProductProductsDTO()
                    {
                        sku = sku,
                        productId = result
                    };
                    Products.Add(pop);
                }
                return Products.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
