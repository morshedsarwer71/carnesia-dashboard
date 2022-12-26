using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.Dashboard.ReturnRefund;

namespace Carnesia.Application.Dashboard.ReturnRefund
{
    public interface IReturnRefund
    {
        Task<bool> IssueReturnRefund(CreateReturnRefundDTO items);
        Task<ReturnRefundDTO> GetItem(string trncode, string uid);
    }
}
