using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.Dashboard.GenerateBill;

namespace Carnesia.Application.Dashboard.GenerateBill
{
    public interface IGenerateBill
    {
        Task<GenerateBillUIDDataDTO> GetProductByUid(string uid);
        Task<GenerateBillCustomerInfoDTO> GetCustomerInfo(string phoneOrId);
        Task<decimal> GetDiscount(string code, decimal subTotal, int customerId);
        Task<GenerateBillPosResponseDTO> NewPOS(GenerateBillPOSDTO pos);
        Task<GenerateBillCustomerCreateResponseDTO> CreateCustomer(GenerateBillCreateCustomerDTO customer);
        Task<GenerateBillInvoiceDTO> GetInvoiceData(string trnCode);
        Task<GenerateBillComboDetailsDTO> GetComboDetails(string bcCode);
    }
}
