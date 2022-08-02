using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.PaymentOffer
{
    public class SideTextDTO
    {
        public int id { get; set; }
        public string offerText { get; set; }
        public bool isPublish { get; set; }
        public DateTime createdAt { get; set; }
    }
}
