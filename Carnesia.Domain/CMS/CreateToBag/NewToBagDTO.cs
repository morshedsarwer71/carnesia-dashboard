using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.CreateToBag
{
    public class NewToBagDTO
    {
        public AddToBagSectionDTO createToBagSectionDTO { get; set; }
        public List<AddToBagDTO> toBagDTOs { get; set; }
    }
}
