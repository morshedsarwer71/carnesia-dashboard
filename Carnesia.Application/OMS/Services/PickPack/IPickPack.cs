using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.OMS.PickPack;

namespace Carnesia.Application.OMS.Services.PickPack
{
    public interface IPickPack
    {
        Task<PickPackDTO> GetPickPackByTRN(string trnCode);
        Task<PickPackDTO> ConfirmPicklist(string trnCode);
        Task<PickPackDTO> AddUID(string trnCode, string uid);
    }
}
