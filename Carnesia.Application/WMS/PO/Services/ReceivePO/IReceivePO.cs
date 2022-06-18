using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.WMS.PO.ReceivePO;

namespace Carnesia.Application.WMS.PO.Services.ReceivePO
{
    public interface IReceivePO
    {
        Task<ReceivePODTO> GetPO(string poid);
        Task<ReceivePODTO> ReceivedPoByCode(string poid);
        Task<ReceivePOProductDTO> SubmitReceive(ReceivePOProductDTO PO);
    }
}
