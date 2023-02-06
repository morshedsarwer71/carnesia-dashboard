using Carnesia.Domain.AAF.Bank;
using Carnesia.Domain.CMS.Brand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Application.AAF.Bank
{
    public interface IBank
    {
        Task<List<BankDTO>> GetBanks();
        Task<BankDTO> GetBank(int id);
        Task<bool> CraeteBank(BankDTO bank);
        Task<bool> UpdateBank(BankDTO bank);
    }
}
