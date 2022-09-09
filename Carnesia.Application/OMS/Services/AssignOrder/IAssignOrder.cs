using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.OMS.AssignDelivery.Dispatch;

namespace Carnesia.Application.OMS.Services.AssignOrder
{
    public interface IAssignOrder
    {
        Task<List<CourierDTO>> GetCouriers();
    }
}
