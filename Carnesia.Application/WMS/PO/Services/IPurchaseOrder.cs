using Carnesia.Domain.WMS.PO.Models;
using Carnesia.Domain.WMS.PO.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Application.WMS.PO.Services
{
    public interface IPurchaseOrder
    {
        Task<string> AddPurchaseOrder(PurchaseOrder purchaseOrder);
        Task<MemoryStream> DownLoadExcel();
    }
}
