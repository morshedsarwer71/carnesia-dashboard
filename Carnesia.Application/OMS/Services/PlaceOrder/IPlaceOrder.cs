using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.OMS.PlaceOrder;

namespace Carnesia.Application.OMS.Services.PlaceOrder
{
    public interface IPlaceOrder
    {
        Task<string[]> GetProductsAsSku();
        Task<List<ProductTableDTO>> GetAllProducts();
        Task<ProductTableDTO> GetProductBySKU(string sku);
        Task<PlaceOrderComboProductTableDTO> GetComboByBcCode(string bccode);
        Task<PlaceOrderCouponDTO> ApplyCoupon(string coupon, string platform);
        Task<PlaceOrderResponseDTO> PlaceOrder(PlaceOrderDTO order);
        Task<PlaceOrderDetailsDTO> GetOrderByTrnCode(string trnCode);
        Task<PlaceOrderAutoApplyDTO> GetAutoApply(string trnCode);
        Task<OrderEditResponseDTO> UpdateOrder(OrderEditUpdatedOrderDTO order, string trnCode);
        Task<string> SendOTP(string phone, string otp);
        Task<string> AutoApplyMSG(decimal subTotal);
        Task<PlaceOrderAutoApplyDTO> AutoApplyValue(decimal subTotal);
    }
}
