using Carnesia.Domain.WMS.Bin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Application.WMS.Bin.Services
{
    public interface IBin
    {
        Task<BinDTO> AddBin(BinDTO bin);
        Task<List<GetBinDTO>> GetBins(string bin,int storeId,bool status);
    }
}
