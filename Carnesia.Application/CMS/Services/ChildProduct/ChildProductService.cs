using Carnesia.Domain.CMS.ChildProduct;
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

namespace Carnesia.Application.CMS.Services.ChildProduct
{
    public class ChildProductService : IChildProduct
    {
        private readonly HttpClient _httpClient;
        public ChildProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<BulkCategoryUploadDTO>> CreateBulkCategories(List<BulkCategoryUploadDTO> Categories)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync<List<BulkCategoryUploadDTO>>("Products/categories/bulk", Categories);

                if (result.IsSuccessStatusCode)
                {
                    var json = await result.Content.ReadAsStringAsync();
                    var deserialized = JsonConvert.DeserializeObject<List<BulkCategoryUploadDTO>>(json);
                    return deserialized;
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<BulkImageUploadDTO>> CreateBulkImages(List<BulkImageUploadDTO> Images)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync<List<BulkImageUploadDTO>>("Products/images/bulk", Images);

                if (result.IsSuccessStatusCode)
                {
                    var json = await result.Content.ReadAsStringAsync();
                    var deserialized = JsonConvert.DeserializeObject<List<BulkImageUploadDTO>>(json);
                    return deserialized;
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<string> CreateBulkProducts(List<ChildProductDetailsDTO> products)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("Products/bulk", products);

                if (result.IsSuccessStatusCode)
                {
                    return "Products Created Successfully;";
                }
                throw new NotImplementedException();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task CreateChildProduct(ChildProductDTO ProductData)
        {
            try
            {
                await _httpClient.PostAsJsonAsync("Products", ProductData);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task DeleteImage(int id)
        {
            try
            {
                await _httpClient.DeleteAsync($"Products/deleteproductimage/{id}");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<SingleChildProductDTO> GetChildById(int id)
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<SingleChildProductDTO>($"Products/{id}");
                if (result == null)
                {
                    return null;
                }

                return result;
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

        public async Task UpdateChildProduct(ChildProductUpdateDTO childProduct)
        {
            try
            {
                await _httpClient.PutAsJsonAsync($"Products/{childProduct.updateProductDTO.id}", childProduct);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task UpdateImage(UpdateProductImageDTO Images, int id)
        {
            try
            {
                await _httpClient.PostAsJsonAsync($"Products/addimagetoproducts/{id}", Images);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<ChildProductDetailsDTO>> UploadBulkProducts(InputFileChangeEventArgs e)
        {
            try
            {
                var Products = new List<ChildProductDetailsDTO>();
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
                    var productName = row.Field<string>("ProductName");
                    var productsku = row.Field<string>("ProductSKU");
                    var productParentId = Convert.ToInt32(row.Field<string>("ProductParentId"));
                    var weight = Convert.ToDecimal(row.Field<string>("Weight"));
                    var productDimension = row.Field<string>("ProductDimension");
                    var isPublish = Convert.ToBoolean(row.Field<string>("IsPublish"));
                    var isHasFreeProd = Convert.ToBoolean(row.Field<string>("IsHasFreeProd"));
                    var productPoints = Convert.ToInt32(row.Field<string>("ProductPoints"));
                    var description = row.Field<string>("Description");
                    var isSize = Convert.ToBoolean(row.Field<string>("IsSize"));
                    var colorCode = row.Field<string>("ColorCode");
                    var sizeOrQty = row.Field<string>("SizeOrQty");
                    var colorName = row.Field<string>("ColorName");
                    var vatAmount = Convert.ToDecimal(row.Field<string>("VatAmount"));
                    var metaDescription = row.Field<string>("MetaDescription");
                    var seachTags = row.Field<string>("SeachTags");
                    var metaTags = row.Field<string>("MetaTags");
                    var mrp = Convert.ToDecimal(row.Field<string>("MRP"));
                    var discount = Convert.ToDecimal(row.Field<string>("Discount"));
                    var crossSells = row.Field<string>("CrossSells");
                    var upSells = row.Field<string>("UpSells");
                    var metaTitle = row.Field<string>("MetaTitle");
                    var isPercent = Convert.ToBoolean(row.Field<string>("IsPercent"));
                    var uom = row.Field<string>("UOM");
                    var productCode = row.Field<string>("ProductCode");


                    var pop = new ChildProductDetailsDTO()
                    {
                        productName = productName,
                        productsku = productsku,
                        productParentId = productParentId,
                        weight = weight,
                        productDimension = productDimension,
                        isPublish = isPublish,
                        isHasFreeProd = isHasFreeProd,
                        productPoints = productPoints,
                        description = description,
                        isSize = isSize,
                        colorCode = colorCode,
                        sizeOrQty = sizeOrQty,
                        colorName = colorName,
                        vatAmount = vatAmount,
                        metaDescription = metaDescription,
                        seachTags = seachTags,
                        metaTags = metaTags,
                        mrp = mrp,
                        discount = discount,
                        crossSells = crossSells,
                        upSells = upSells,
                        metaTitle = metaTitle,
                        isPercent = isPercent,
                        uom = uom,
                        productCode = productCode
                        
                    };
                    Products.Add(pop);
                }
                return Products.Where(x => x.productName != null).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<BulkCategoryUploadDTO>> UploadXLSXFileForCategory(InputFileChangeEventArgs e)
        {
            try
            {
                var Categories = new List<BulkCategoryUploadDTO>();
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
                    var parentCatId = Convert.ToInt32(row.Field<string>("ParentCat"));
                    var childCatId = Convert.ToInt32(row.Field<string>("ChildCat"));
                    var gChildCatId = Convert.ToInt32(row.Field<string>("GrandChildCat"));

                    var pop = new BulkCategoryUploadDTO()
                    {
                        productCode = productCode,
                        parentCatId = parentCatId,
                        childCatId = childCatId,
                        gChildCatId = gChildCatId,
                    };
                    Categories.Add(pop);
                }
                return Categories.Where(x => x.parentCatId != null).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<BulkImageUploadDTO>> UploadXLSXFileForImage(InputFileChangeEventArgs e)
        {
            try
            {
                var Images = new List<BulkImageUploadDTO>();
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
                    var url = row.Field<string>("ImageURL");
                    var imageName = row.Field<string>("ImageName");
                    var altImageName = row.Field<string>("AltText");
                    var productCode = row.Field<string>("ProductCode");

                    var pop = new BulkImageUploadDTO()
                    { 
                        altImageName = altImageName,
                        imageName = imageName,
                        url = url,
                        productCode = productCode
                    };
                    Images.Add(pop);
                }
                return Images.Where(x => x.url != null).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
