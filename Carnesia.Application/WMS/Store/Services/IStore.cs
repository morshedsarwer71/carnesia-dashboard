using Carnesia.Domain.WMS.Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Application.WMS.Store.Services
{
    public interface IStore
    {
        Task<List<StoreDTO>> GetStoresAsync();
        Task<string[]> GetStoreNameAsString();
        Task<StoreDTO> GetStore(string storeName);
        Task<string> CheckVatable();
    }
}
