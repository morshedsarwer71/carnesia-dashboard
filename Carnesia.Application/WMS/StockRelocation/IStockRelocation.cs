using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.WMS.BinTransfer;

namespace Carnesia.Application.WMS.StockRelocation
{
    public interface IStockRelocation
    {
        Task<BinTransferDTO> RelocateProduct(string bin, string uid);
    }
}
