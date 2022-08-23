using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.WMS.BinInscan;

namespace Carnesia.Application.WMS.PutAway.BinInscan
{
    public interface IBinInscan
    {
        Task<BinInscanDTO> GetSingleBinInscan(string uid, string bin);
        Task<BinDetailsPoco> GetBinDetails(string bin);
    }
}
