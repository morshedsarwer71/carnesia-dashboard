using Carnesia.Domain.WMS.PO.Models;
using Carnesia.Domain.WMS.PO.ViewModels;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.Common.ResponseData;
using Carnesia.Domain.WMS.PO.Models.Awaiting;
using Carnesia.Domain.WMS.PO.POCO;
using Carnesia.Domain.WMS.PO.ViewModels.Awaiting;
using Microsoft.AspNetCore.Components.Forms;
using Carnesia.Domain.WMS.UIDReport;
using Carnesia.Domain.WMS.TrackUID;

namespace Carnesia.Application.WMS.PO.Services
{
    public interface IPurchaseOrder
    {
        Task<string> AddPurchaseOrder(PurchaseOrder purchaseOrder);
        Task DownLoadExcel(IJSRuntime jSRuntime);
        Task<List<PoProductDTO>> UploadExcelFile(InputFileChangeEventArgs e);
        Task<PoProductDTO> AddProduct(PoProductDTO poProductDto);
        Task<List<AwaitingPo>> AwaitingPo();
        Task<List<AwaitingPo>> AwaitingPoByPoCode(string poCode);
        Task<Response> PoApprove(string poCode);
        Task<AwaitingPoDetails> AwaitingPoDetails(string poCode);
        Task<List<POListPoco>> GetPoList();

        Task<string> ApproveSelectedItems(string poCode, List<PoProductDTO> poProducts);
        Task<string> RemoveSelectedItems(string poCode, List<PoProductDTO> poProducts);

        Task<string> GenerateUID(UIDPoco form);
        Task TestPrint();
    }
}
