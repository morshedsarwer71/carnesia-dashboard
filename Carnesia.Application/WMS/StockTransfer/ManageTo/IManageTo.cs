using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.WMS.ManageTO;
using Carnesia.Domain.WMS.OutScan;

namespace Carnesia.Application.WMS.StockTransfer.ManageTo
{
	public interface IManageTo
	{
		Task<List<ManageToDTO>> GetAllManageTo();
		Task<OutScanDTO> GetOutScan(string picklistID, string uid);
		Task GeneratePicklistID(string trnCode);
	}
}
