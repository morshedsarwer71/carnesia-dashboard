using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.Dashboard.Orders;

namespace Carnesia.Application.Dashboard.Orders
{
    public interface IOrders
    {
        Task<List<OrderDTO>> GetOrders();
        Task<List<OrderDTO>> GetOrdersBySearch(string searchTearm);
    }
}
