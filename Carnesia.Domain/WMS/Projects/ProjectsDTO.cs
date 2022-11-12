using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.WMS.Projects
{
    public class ProjectsDTO
    {
        public int id { get; set; }
        public string projectCode { get; set; }
        public DateTime? createDate { get; set; }
        public string storeName { get; set; }
        public string status { get; set; }
        public string projectType { get; set; }
        public DateTime? lastUpdateDate { get; set; }
        public string createdBy { get; set; }
    }

    public class UpdateProjectDTO
	{
        public int id { get; set; }
		public string projectType { get; set; }
	}
}
