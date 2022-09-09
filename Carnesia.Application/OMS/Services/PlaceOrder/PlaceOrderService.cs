using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;
using Carnesia.Domain.OMS.PlaceOrder;

namespace Carnesia.Application.OMS.Services.PlaceOrder
{
    public class PlaceOrderService : IPlaceOrder
    {
        private readonly HttpClient _httpClient;
        public PlaceOrderService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<PlaceOrderCouponDTO> ApplyCoupon(string coupon, string platform)
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<PlaceOrderCouponDTO>($"Voucher/generalcheck/{coupon}/{platform}");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<ProductTableDTO>> GetAllProducts()
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<ProductTableDTO>>("Products/placeorderproduct");
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<PlaceOrderAutoApplyDTO> GetAutoApply(string trnCode)
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<PlaceOrderAutoApplyDTO>($"Oms/autoapplycheck/{trnCode}");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<PlaceOrderDetailsDTO> GetOrderByTrnCode(string trnCode)
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<PlaceOrderDetailsDTO>($"Order/getorderbytrn/{trnCode}");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<ProductTableDTO> GetProductBySKU(string sku)
        {
            try
            {
                var result = await GetAllProducts();
                var pIndex = result.FindIndex(x => x.sku == sku);

                return result[pIndex];
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<string[]> GetProductsAsSku()
        {
            try
            {
                var list = new List<string>();
                var result = await GetAllProducts();
                list.AddRange(result.Select(x => x.sku));
                return list.ToArray();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> PlaceOrder(PlaceOrderDTO order)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("Order/placeorder", order);

                if (result.IsSuccessStatusCode) return true;
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
