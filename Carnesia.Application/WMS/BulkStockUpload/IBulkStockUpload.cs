using Carnesia.Domain.WMS.BulkStockUpload;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Application.WMS.BulkStockUpload
{
    public interface IBulkStockUpload
    {
        Task<List<FilterStockProductDTO>> GetProducts(StockFilterDTO stockFilter);
        Task<bool> UpdateStock(StockFilterDTO stockFilter);
    }
}
