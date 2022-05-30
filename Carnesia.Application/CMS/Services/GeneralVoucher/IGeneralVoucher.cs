using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.CMS.GeneralVoucher;

namespace Carnesia.Application.CMS.Services.GeneralVoucher
{
    public interface IGeneralVoucher
    {
        Task CreateNewVoucher(AddGeneralVoucherDTO VoucherData);
    }
}
