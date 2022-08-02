using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.CMS.PaymentOffer;

namespace Carnesia.Application.CMS.Services.PaymentOffer
{
    public interface IPaymentOffer
    {
        Task<List<SideTextDTO>> GetSideTexts(string apiURL);
        Task<bool> ToggleSideText(string apiURL, int id);
        Task<bool> CreateNewOffer(string apiURL, AddTextDTO offer);
    }
}
