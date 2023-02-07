using Carnesia.Domain.WMS.AllWarehouseStock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Application.WMS.Report.WarehouseStock
{
    public interface IWarehouseStock
    {
        Task<List<AllwarehouseStockDTO>> GetWarehouseStock(AllWarehouseStockFilterDTO filter);
    }
}
