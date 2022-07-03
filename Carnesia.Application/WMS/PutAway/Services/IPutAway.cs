using Carnesia.Application.WMS.PutAway.Poco;
using Carnesia.Domain.WMS.BinInscan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Application.WMS.PutAway.Services
{
    public interface IPutAway
    {
        Task<List<BinInscanProductDTO>> SingleBinInscan(string uid, string binNumber, List<BinInscanProductDTO> list);
        Task<BinInscansPoco> BulkBinInscan(string poCode,string binNumber);
        Task<UIDHistoryPoco> GetUIDHistory(string uid);

        Task<BinDetailsPoco> BinDetails(string bin);
        //Task<IList<BinInscanProductDTO>> BinInGroup(List<BinInscanProductDTO> bins);
    }
}
