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

        public async Task<PlaceOrderResponseDTO> PlaceOrder(PlaceOrderDTO order)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("Order/placeorder", order);

                var json = await result.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<PlaceOrderResponseDTO>(json);

                return data;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<string> SendOTP(string phone, string otp)
        {
            using(var client = new HttpClient())
            {
                string message = $"Your OTP to change contact number for your order is {otp}.";
                using (var response = await client.GetAsync($"https://api.mobireach.com.bd/SendTextMessage?Username=carnesia&Password=Sampas$$w0rd&From=CARNESIA&To={phone}&Message={message}"))
                {
                    var successString = "OTP sent";
                    var erroString = "Faild";
                    if (response.IsSuccessStatusCode) return successString;
                    return erroString;
                }
            }
        }

        public async Task<OrderEditResponseDTO> UpdateOrder(OrderEditUpdatedOrderDTO order, string trnCode)
        {
            try
            {
                var result = await _httpClient.PutAsJsonAsync($"Order/orderedit/{trnCode}", order);

                var json = await result.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<OrderEditResponseDTO>(json);

                return data;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}
