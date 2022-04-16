using Carnesia.Domain.Vendor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Application.Vendor.Services
{
    public interface IVendor
    {
        Task<IEnumerable<VendorDTO>> GetVendorsAsync();
        Task<string[]> GetVendorsNameAsString();
        Task<VendorDTO> GetVendor(string vendorName);
    }
}
