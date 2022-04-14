using Carnesia.Domain.WMS.PO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.PO.ViewModels
{
    public class PurchaseOrder
    {
        public CreatePODTO createPODTO { get; set; }
        public List<PoProductDTO> poProductDTOs { get; set; }
    }
}
