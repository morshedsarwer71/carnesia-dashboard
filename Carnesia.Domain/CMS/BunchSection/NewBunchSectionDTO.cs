using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.BunchSection
{
    public class NewBunchSectionDTO
    {
        public string sectionName { get; set; }
        public string allignment { get; set; }
        public List<BunchThumDTO> bunchThums { get; set; }
    }

    public class BunchThumDTO
    {
        public string name { get; set; }
        public string base64Attch { get; set; }
        public string link { get; set; }
    }
}
