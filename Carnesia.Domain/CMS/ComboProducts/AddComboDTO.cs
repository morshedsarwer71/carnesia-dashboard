using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.ComboProducts
{
    public class AddComboDTO
    {
        public AddComboDetailsDTO comboProductDTO { get; set; }
        public List<AddComboProductDTO> comboProductTags { get; set; }
    }
}
