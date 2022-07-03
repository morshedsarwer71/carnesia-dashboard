using Carnesia.Domain.Vendor.Models;
using Carnesia.Domain.Vendor.POCO;
using Microsoft.AspNetCore.Components.Forms;
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
        Task<bool> AddVendor(PostVendorPoco vendorPoco);
        Task<bool> UpdateVendor(VendorDTO vendor);
        Task<List<PostVendorPoco>> UploadXLSXFile(InputFileChangeEventArgs e);
        Task<List<PostVendorPoco>> CreateBulkVendors(List<PostVendorPoco> Vendors);
    }
}
