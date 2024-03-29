﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.CMS.ParentProduct;
using Carnesia.Domain.CMS.SimpleProduct;
using Microsoft.AspNetCore.Components.Forms;

namespace Carnesia.Application.CMS.Services.ParentProduct
{
    public interface IParentProduct
    {
        Task<List<ParentProductDTO>> GetParentProducts();

        Task<bool> CreateParentProduct(CreateParentProductDTO ParentProduct);
        Task<string> CreateParentProductReturnID(SimpleProductParentDTO ParentProduct);

        Task<string[]> GetParentProductAsString();

        Task<int> GetParentProductID(string ProductName);
        Task<bool> UpdateParentProduct(ParentProductDTO ParentProduct);
        Task<List<CreateParentProductDTO>> UploadXLSXFile(InputFileChangeEventArgs e);
        Task<List<CreateParentProductDTO>> CreateBulkParents(List<CreateParentProductDTO> Parents);
    }
}
